using DotNetInterview.Models;
using DotNetInterview.Web.Services.Interfaces;
using DotNetInterview.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DotNetInterview.Web.Services
{
    public class AccountService : IAccountService
    {
        public bool Register(SignInManager<DNIUser> signIn, RegisterVM model)
        {
            if (model.Password != model.ConfirmPassword)
            {
                return false;
            }
            var user = new DNIUser
            {
                UserName = model.Username,
                Email = model.Email,
                Forname = model.Forname,
                Surname = model.Surname,
                Dob = model.Dob,
                Nationality = model.Nationality,
                Experience = model.Experience
            };
            var result = signIn.UserManager.CreateAsync(user, model.Password)
                .GetAwaiter()
                .GetResult()
                .Succeeded;
            if (result && signIn.UserManager.Users.Count() == 1)
            {
                this.SetRole(signIn, model, "Admin");
            }
            return result;
        }

        public bool Login(SignInManager<DNIUser> signIn, LoginVM model)
        {
            var user = signIn.UserManager.FindByNameAsync(model.Username)
                .GetAwaiter()
                .GetResult();
            if (user == null)
            {
                return false;
            }
            var result = signIn.PasswordSignInAsync(user, model.Password, model.RememberMe, false)
                .GetAwaiter()
                .GetResult()
                .Succeeded;
            return result;
        }

        public bool Loout(SignInManager<DNIUser> signIn, ClaimsPrincipal model)
        {
            signIn.SignOutAsync()
                .GetAwaiter()
                .GetResult();
            //  var user = signIn.UserManager.FindByNameAsync(model.Username);
            //   signIn.IsSignedIn(this.User);
            return true;
        }

        bool SetRole(SignInManager<DNIUser> signIn, LoginVM model, string role)
        {
            var user = signIn.UserManager.FindByNameAsync(model.Username)
                .GetAwaiter()
                .GetResult();
            var added = signIn.UserManager.AddToRoleAsync(user, role)
                 .GetAwaiter()
                 .GetResult()
                 .Succeeded;
            return added;
        }
    }
}
