using BookWise.Core.Models.Author;
using BookWise.Core.Models.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWise.Core.Contracts
{
    public interface IAuthorService
    {
        Task<int> Create(AuthorDetailsModel model);

        Task<AuthorDetailsModel> Details(int id);

        Task<bool> AuthorExists(int authorId);

        IEnumerable<AuthorFullModel> All();
        Task Edit(int id, AuthorDetailsModel model);

        Task<IEnumerable<BookHomeModel>> AllBooks();

        Task<List<BookHomeModel>> GetBooksByAuthor(int authorId);
    }
}
