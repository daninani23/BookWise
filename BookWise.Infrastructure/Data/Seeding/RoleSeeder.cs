using BookWise.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookWise.Data.Seeding
{
    public class RoleSeeder : ISeeder
    {
        public async Task SeedAsync(IServiceScope serviceScope)
        {
            var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

            if (await roleManager.Roles.AnyAsync())
            {
                return;
            }

            var roles = new List<ApplicationRole>()
            {
                new ApplicationRole(GlobalConstants.AdministratorRoleName),
                new ApplicationRole(GlobalConstants.UserRoleName),
            };

            foreach (var role in roles)
            {
                await roleManager.CreateAsync(role);
            }
        }
    }
}
