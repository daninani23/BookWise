using BookWise.Core.Contracts;
using BookWise.Core.Models.Book;
using BookWise.Infrastructure.Data.Common;
using BookWise.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Author = BookWise.Infrastructure.Data.Models.Author;
using Book = BookWise.Infrastructure.Data.Models.Book;
using Genre = BookWise.Infrastructure.Data.Models.Genre;

namespace BookWise.Core.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository repo;

        public BookService(IRepository _repo)
        {
            repo = _repo;
        }

        public IEnumerable<BookServiceModel> All()
        {
            return GetBooks(repo.All<Book>().OrderByDescending(x => x.Title));
        }

        private static IEnumerable<BookServiceModel> GetBooks(IQueryable<Book> bookQuery)
        {
            var books = bookQuery
                .Select(b => new BookServiceModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    Description = b.Description.Substring(0, 150),
                    ImageUrl = b.ImageUrl,
                    BookGenres = b.BookGenres.Select(bg => bg.Genre.Name).ToList(),
                    BookAuthors = b.BookAuthors.Select(bg => $"{bg.Author.FirstName} {bg.Author.LastName}").ToList()
                }).ToList();

            return books;
        }

        public async Task<IEnumerable<AuthorModel>> AllAuthors()
        {
            return await repo.AllReadonly<Author>()
                .OrderBy(a => a.FirstName).ThenBy(a => a.LastName)
                .Select(a => new AuthorModel()
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<GenreModel>> AllGenres()
        {
            return await repo.AllReadonly<Genre>()
                .OrderBy(g => g.Name)
                .Select(g => new GenreModel()
                {
                    Id = g.Id,
                    Name = g.Name
                })
                .ToListAsync();
        }

        //public async Task<bool> AuthorExists(int authorId)
        //{
        //    return await repo.AllReadonly<Author>().AnyAsync(a => a.Id == authorId);
        //}

        public async Task<int> Create(BookModel model)
        {

            var book = new Book()
            {
                Title = model.Title,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                NumberOfPages = model.NumberOfPages,
                PublicationDate = model.PublicationDate,
                Publisher = model.Publisher

            };

            await repo.AddAsync(book);
            await repo.SaveChangesAsync();

            foreach (var genreid in model.SelectedGenres)
            {
                var existingGenre = await repo.GetByIdAsync<Genre>(genreid);
                if (existingGenre == null)
                {

                }
                else
                {
                    var bookGenre = new BookGenre
                    {
                        BookId = book.Id,
                        GenreId = genreid
                    };

                    await repo.AddAsync<BookGenre>(bookGenre);
                }
            }

            foreach (var authorid in model.SelectedAuthors)
            {
                var existingAuthor = await repo.GetByIdAsync<Author>(authorid);
                if (existingAuthor == null)
                {

                }
                else
                {
                    var bookAuthor = new BookAuthor
                    {
                        BookId = book.Id,
                        AuthorId = authorid
                    };

                    await repo.AddAsync<BookAuthor>(bookAuthor);
                }
            }

            await repo.SaveChangesAsync();
            return book.Id;
        }


        //public async Task<bool> GenreExists(int genreId)
        //{
        //    return await repo.AllReadonly<Genre>().AnyAsync(g => g.Id == genreId);
        //}

        public async Task<IEnumerable<BookHomeModel>> LastFourBooks()
        {
            return await repo.AllReadonly<Book>()
                .OrderByDescending(b => b.Id)
                .Select(b => new BookHomeModel()
                {
                    Id = b.Id,
                    Title = b.Title,
                    ImageUrl = b.ImageUrl
                })
                .Take(4)
                .ToListAsync();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return repo.AllReadonly<Book>()
                            .Include(b => b.BookGenres)
                                .ThenInclude(bg => bg.Genre)
                            .Include(b => b.BookAuthors)
                                .ThenInclude(ba => ba.Author)
                            .ToList();
        }


        public async Task<BookDetailsModel> Details(int id) => await repo.AllReadonly<Book>()
            .Where(b => b.Id == id)
            .Select(bg => new BookDetailsModel()
            {
                Id = bg.Id,
                Title = bg.Title,
                ImageUrl = bg.ImageUrl,
                Description = bg.Description,
                PublicationDate = bg.PublicationDate,
                ReviewsCount = bg.Reviews.Count(),
                Rating = bg.Reviews.Average(r => r.Rating) == null ? 0 : bg.Reviews.Average(r => r.Rating),
                Publisher = bg.Publisher,
                NumberOfPages = bg.NumberOfPages,
                BookGenres = bg.BookGenres.Select(bt => bt.Genre.Name).ToList(),
                BookAuthors = bg.BookAuthors.Select(bt => $"{bt.Author.FirstName} {bt.Author.LastName}").ToList()

            }).FirstAsync();

        public async Task<bool> BookExist(int id) 
        {
            return await repo.AllReadonly<Book>().AnyAsync(b => b.Id ==id); 
        }
    }
}
