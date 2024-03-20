using BookWise.Infrastructure.Data;
using BookWise.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookWise.Data.Seeding
{
    public class BookAuthorSeeder : ISeeder
    {
        public async Task SeedAsync(IServiceScope serviceScope)
        {
            var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (await dbContext.BookAuthors.AnyAsync())
            {
                return;
            }

            var bookauthors = new List<BookAuthor>()
            {
                new BookAuthor()
                {
                    BookId=1,
                    AuthorId=1,
                },
                new BookAuthor()
                {
                    BookId=2,
                    AuthorId=2,
                },
                new BookAuthor()
                {
                    BookId=3,
                    AuthorId=3,
                },
                new BookAuthor()
                {
                    BookId=4,
                    AuthorId=4,
                },
                new BookAuthor()
                {
                    BookId=5,
                    AuthorId=5,
                },
                new BookAuthor()
                {
                    BookId=6,
                    AuthorId=6,
                },
                new BookAuthor()
                {
                    BookId=6,
                    AuthorId=2,
                },
                new BookAuthor()
                { 
                    BookId=7,
                    AuthorId=7,
                }
            };

            await dbContext.BookAuthors.AddRangeAsync(bookauthors);
            await dbContext.SaveChangesAsync();
        }
    }
}    
