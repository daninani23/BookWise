using System.ComponentModel.DataAnnotations;

namespace BookWise.Core.Models.Book
{
    public class AllBooksQueryModel
    {
        public const int BooksPerPage = 3;
        public string? Genre { get; set; }

        [Display(Name ="Search by text")]
        public string? SearchTerm { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int TotalBooksCount { get; set; }
        public IEnumerable<string> Genres { get; set; }= Enumerable.Empty<string>();

        public IEnumerable<BookServiceModel> Books { get; set; }= Enumerable.Empty<BookServiceModel>();

    }
}
