using BookWise.Core.Models.Book;
using BookWise.Core.Models.Review;

namespace BookWise.Core.Contracts
{
    public interface IBookService
    {
        IEnumerable<BookServiceModel> ByGenreType(string genre);
        IEnumerable<BookServiceModel> All();
        Task<IEnumerable<BookHomeModel>> LastFourBooks();
        Task<BookDetailsModel> Details(int id);

        Task<IEnumerable<GenreModel>> AllGenres();
        Task<IEnumerable<AuthorModel>> AllAuthors();
        Task<bool> BookExist(int id);

        Task Edit(int id, BookModel model);

        Task<bool> GenreExists(int genreId);
        Task<bool> AuthorExists(int authorId);
        Task<int> Create(BookModel model);

        Task<bool> Delete(int id);
        Task<List<AuthorModel>> GetAuthorsByBook(int bookId);
        Task<List<ReviewViewModel>> GetReviewsByBook(int bookId);

        Task<BookQueryServiceModel> AllF(
            string? genre=null,
            string? searchTerm=null,
            int currentPage=1,
            int boksPerPage=1);

        Task<IEnumerable<string>> AllGenresNames();


    }
}
