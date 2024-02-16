using BookWise.Core.Models.Book;

namespace BookWise.Core.Contracts
{
    public interface IBookService
    {
        IEnumerable<BookServiceModel> All();
        Task<IEnumerable<BookHomeModel>> LastFourBooks();

        Task<IEnumerable<GenreModel>> AllGenres();
        Task<IEnumerable<AuthorModel>> AllAuthors();

        //Task<bool> GenreExists(int genreId);
        //Task<bool> AuthorExists(int authorId);
        Task<int> Create(BookModel model);
    }
}
