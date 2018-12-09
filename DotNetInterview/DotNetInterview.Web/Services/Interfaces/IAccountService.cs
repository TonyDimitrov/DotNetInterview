using DotNetInterview.Models;
using DotNetInterview.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace DotNetInterview.Web.Services.Interfaces
{
    public interface IAccountService
    {
        bool Register(SignInManager<DNIUser> signIn, RegisterVM model);

        bool Login(SignInManager<DNIUser> signIn, LoginVM model);

        bool Loout(SignInManager<DNIUser> signIn, ClaimsPrincipal model);
    }
}
