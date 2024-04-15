using System.ComponentModel.DataAnnotations;

namespace BookWise.Core.Models.Book
{
    public class BookServiceModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        public List<string> BookAuthors { get; set; } = new List<string>();
        public List<string> BookGenres { get; set; } = new List<string>();

    }
}
