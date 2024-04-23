using BookWise.Core.Contracts;
using BookWise.Core.Models.Author;
using BookWise.Core.Models.Book;
using BookWise.Infrastructure.Data.Common;
using BookWise.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using static BookWise.Infrastructure.Data.DataConstants;
using Author = BookWise.Infrastructure.Data.Models.Author;
using Book = BookWise.Infrastructure.Data.Models.Book;

namespace BookWise.Core.Services
{
    public class AuthorService:IAuthorService
    {
        private readonly IRepository repo;

        public AuthorService(IRepository _repo)
        {
            repo = _repo;
        }
        public IEnumerable<AuthorFullModel> All()
        {
            return GetAuthors(repo.All<Author>().OrderByDescending(x => x.FirstName).ThenBy(x=>x.LastName));
        }

        private static IEnumerable<AuthorFullModel> GetAuthors(IQueryable<Author> authorQuery)
        {
            var books = authorQuery
                .Select(b => new AuthorFullModel
                {
                   Id= b.Id,
                   FirstName= b.FirstName,
                   LastName= b.LastName,
                   ImageUrl = b.ImageUrl,
                   Description= b.Description,
                }).ToList();

            return books;
        }

        public async Task<int> Create(AuthorDetailsModel model)
        {
            var author = new Author()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                ImageUrl = model.ImageUrl,
                BirthDate = model.BirthDate,
                Description= model.Description,
            };

            await repo.AddAsync(author);
            await repo.SaveChangesAsync();

            foreach (var bookid in model.SelectedBooks)
            {
                var existingBook = await repo.GetByIdAsync<Book>(bookid);
                if (existingBook == null)
                {

                }
                else
                {
                    var bookauthor = new BookAuthor
                    {
                        BookId = bookid,
                        AuthorId = author.Id,
                    };

                    await repo.AddAsync<BookAuthor>(bookauthor);
                }
            }

            return author.Id;
        }

        public async Task<AuthorDetailsModel> Details(int id)
        => await repo.AllReadonly<Author>()
            .Where(b => b.Id == id)
            .Select(bg => new AuthorDetailsModel() {
                FirstName= bg.FirstName,
                LastName= bg.LastName,
                BirthDate= bg.BirthDate,
                ImageUrl= bg.ImageUrl,
                Description= bg.Description,
            }).FirstAsync();

       

        public async Task<bool> AuthorExists(int authorid)
        {
            return await repo.AllReadonly<Author>().AnyAsync(b => b.Id == authorid);
        }


        public async Task Edit(int id, AuthorDetailsModel model)
        {
            var author = await repo.All<Author>()
                    .Include(b => b.BookAuthors)
                    .FirstOrDefaultAsync(b => b.Id == id);

            author.ImageUrl = model.ImageUrl;
            author.FirstName= model.FirstName;
            author.LastName= model.LastName;
            author.BirthDate=model.BirthDate;
            author.Description= model.Description;

            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<BookHomeModel>> AllBooks()
        {
            return await repo.AllReadonly<Book>()
                .OrderBy(b => b.Title)
                .Select(b => new BookHomeModel()
                {
                    Id = b.Id,
                    Title = b.Title
                })
                .ToListAsync();
        }

        public async Task<List<BookHomeModel>> GetBooksByAuthor(int authorId)
        {
            var booksByAuthor = await repo.All<Book>()
       .Where(b => b.BookAuthors.Any(a => a.AuthorId == authorId))
       .Select(b => new BookHomeModel
       {
           Id = b.Id,
           Title = b.Title,
           ImageUrl= b.ImageUrl
       })
       .ToListAsync();

            return booksByAuthor;
        }


    }
}
