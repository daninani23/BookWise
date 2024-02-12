using BookWise.Core.Models.Book;

namespace BookWise.Core.Contracts
{
    public interface IBookService
    {
        Task<IEnumerable<BookHomeModel>> LastFourBooks();
    }
}
