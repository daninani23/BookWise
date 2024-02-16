using BookWise.Core.Contracts;
using BookWise.Core.Models.Book;
using BookWise.Infrastructure.Data.Common;
using BookWise.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using static BookWise.Infrastructure.Data.DataConstants;
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
            return GetBooks(this.repo.AllReadonly<Book>().OrderByDescending(x=>x.Title));
        }

        private static IEnumerable<BookServiceModel> GetBooks(IEnumerable<Book> bookQuery)
            => bookQuery
                .Select(b => new BookServiceModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    Publisher=b.Publisher,
                    Description = b.Description.Substring(0, 150),
                    ImageUrl = b.ImageUrl,
                    GenreNames = string.Join(", ", b.BookGenres.Select(bg => bg.Genre.Name)),
                    AuthorNames = string.Join(", ", b.BookAuthors.Select(bg => $"{bg.Author.FirstName} {bg.Author.LastName}"))
                })
                .ToList();

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
                    Id= b.Id,
                    Title= b.Title,
                    ImageUrl= b.ImageUrl
                })
                .Take(4)
                .ToListAsync();
        }
    }
}
