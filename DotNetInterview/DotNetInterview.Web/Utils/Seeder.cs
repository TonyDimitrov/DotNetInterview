
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DotNetInterview.Web.Utils
{
    public static class Seeder
    {
        private static string roleName = "Admin";

        public static void Seed(IServiceProvider provider)
        {
            var roleManager = provider.GetService<RoleManager<IdentityRole>>();
            var role = roleManager.RoleExistsAsync(roleName)
                .GetAwaiter()
                .GetResult();
            if (!role)
            {
                roleManager.CreateAsync(new IdentityRole { Name = roleName })
                .GetAwaiter()
                .GetResult();
            }
        }
    }
}
