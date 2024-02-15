using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookWise.Infrastructure.Data.DataConstants.Book;

namespace BookWise.Core.Models.Book
{
    public class BookModel
    {
        [Required(ErrorMessage = "Title of book is required.")]
        [StringLength(TitleMaxLength,MinimumLength =TitleMinLength,ErrorMessage = "Title should be between {2} and {1} characters long.")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "Description of book is required.")]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength,ErrorMessage = "Book should be between {2} and {1} characters long.")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "Pages of book is required.")]
        [Range(PageNumMinLength,PageNumMaxLength,ErrorMessage= "Book should be between {1} and {2} pages.")]
        [Display(Name = "Print length")]
        public int NumberOfPages { get; set; }


        [Display(Name ="Publication date")]
        public DateTime? PublicationDate { get; set; }

        [Required(ErrorMessage = "Publisher of book is required.")]
        [StringLength(PublisherMaxLength,MinimumLength=PublisherMinLength,ErrorMessage = "Publisher should be between {2} and {1} characters long.")]
        public string Publisher { get; set; } = null!;

        [Display(Name ="Image URL")]
        public string ImageUrl { get; set; } = null!;

        public List<GenreModel> Genres { get; set; } = new List<GenreModel>();
        public List<AuthorModel> Authors { get; set; }= new List<AuthorModel>(); 

        public List<int> SelectedAuthors { get; set; } = new List<int>();
        public List<int> SelectedGenres { get; set; } = new List<int>();

    }
}
