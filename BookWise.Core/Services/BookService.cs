using BookWise.Core.Contracts;
using BookWise.Core.Models.Book;
using BookWise.Infrastructure.Data.Common;
using BookWise.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWise.Core.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository repo;

        public BookService(IRepository _repo)
        {
            repo = _repo;
        }

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
