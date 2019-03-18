using DotNetInterview.Data;
using DotNetInterview.Models;
using DotNetInterview.Web.Services.Interfaces;
using DotNetInterview.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetInterview.Web.Controllers
{
    public class AccountController : BaseController
    {
        private SignInManager<DNIUser> signIn;
        private IAccountService accountService;

        public AccountController(DotNetInterviewDbContext dbContext, SignInManager<DNIUser> signIn, IAccountService accountService)
            :base(dbContext)
        {
            this.signIn = signIn;
            this.accountService = accountService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var isRegistered = this.accountService.Register(signIn, model);
                if (isRegistered)
                {
                    return this.Redirect("/home/index");
                }
            }

            return this.View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                var loggedIn = this.accountService.Login(signIn, model);
                if (loggedIn)
                {
                    return this.Redirect("/home/index");
                }
            }
            return this.View(model);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            this.accountService.Loout(signIn, this.User);
            return this.Redirect("/home/index");
        }
    }
}
