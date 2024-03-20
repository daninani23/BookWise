using BookWise.Infrastructure.Data;
using BookWise.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookWise.Data.Seeding
{
    public class GenreSeeder : ISeeder
    {
        public async Task SeedAsync(IServiceScope serviceScope)
        {
            var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (await dbContext.Genres.AnyAsync())
            {
                return;
            }

            var genres = new List<Genre>()
            {
                new Genre()
                {
                    Name = "Fantasy"
                },
                new Genre()
                {
                    Name = "Horror"
                },
                new Genre()
                {
                    Name = "Biography"
                },
                new Genre()
                {
                    Name = "Romance"
                },
                new Genre()
                {
                    Name = "Classic"
                },
                new Genre()
                {
                    Name = "Self Help"
                }
            };

            await dbContext.Genres.AddRangeAsync(genres);
            await dbContext.SaveChangesAsync();
        }
    }
}
