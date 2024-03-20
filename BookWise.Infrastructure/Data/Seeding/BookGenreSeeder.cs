using BookWise.Infrastructure.Data;
using BookWise.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookWise.Data.Seeding
{
    public class BookGenreSeeder:ISeeder
    {
        public async Task SeedAsync(IServiceScope serviceScope)
        {
            var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (await dbContext.BookGenres.AnyAsync())
            {
                return;
            }

            var bookgenres = new List<BookGenre>()
            {
                new BookGenre()
                {
                    BookId=1,
                    GenreId=1,
                },
                new BookGenre()
                {
                    BookId=1,
                    GenreId=4,
                },
                new BookGenre()
                {
                    BookId=2,
                    GenreId=2,
                },
                new BookGenre()
                {
                    BookId=3,
                    GenreId=4,
                },
                new BookGenre()
                {
                    BookId=4,
                    GenreId=3,
                },
                new BookGenre()
                {
                    BookId=5,
                    GenreId=4,
                },
                new BookGenre()
                {
                    BookId=5,
                    GenreId=5,
                },
                new BookGenre()
                {
                    BookId=6,
                    GenreId=2,
                },
                new BookGenre()
                { 
                    BookId=7,
                    GenreId=6
                }
            };

            await dbContext.BookGenres.AddRangeAsync(bookgenres);
            await dbContext.SaveChangesAsync();
        }
    }
}
