using BookWise.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookWise.Data.Seeding
{
    public class UserSeeder : ISeeder
    {
        public async Task SeedAsync(IServiceScope serviceScope)
        {
            var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            if (await userManager.Users.AnyAsync())
            {
                return;
            }

            var admin = new ApplicationUser
            {
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                FirstName="Danina",
                LastName="Ivanova",
            };

            

            var guest = new ApplicationUser
            {
                UserName = "guest",
                NormalizedUserName = "GUEST",
                Email = "guest@mail.com",
                NormalizedEmail = "GUEST@GMAIL.COM",
                FirstName="Teodora",
                LastName="Apostolova",
            };

            await userManager.CreateAsync(admin, GlobalConstants.AdminPassword);
            await userManager.AddToRoleAsync(admin, GlobalConstants.AdministratorRoleName);

            await userManager.CreateAsync(guest, GlobalConstants.UserPassword);
            await userManager.AddToRoleAsync(guest, GlobalConstants.UserRoleName);
        }
    }
}
