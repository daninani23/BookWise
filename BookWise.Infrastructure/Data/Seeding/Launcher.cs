using BookWise.Data.Seeding;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BookWise.Data.Seeding
{
    public static class Launcher
    {
        public static async Task SeedDataBase(IApplicationBuilder application)
        {
            ICollection<ISeeder> seeders = new List<ISeeder>()
            {
                new RoleSeeder(),
                new UserSeeder(),
                new GenreSeeder(),
                new AuthorSeeder(),
                new BookSeeder(),
                new BookAuthorSeeder(),
                new BookGenreSeeder()
            };

            using (var serviceScope = application.ApplicationServices.CreateScope())
            {
                foreach (var seeder in seeders)
                {
                    await seeder.SeedAsync(serviceScope);
                }
            }
        }
    }
}
