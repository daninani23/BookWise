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

        [StringLength(TitleMaxLength,MinimumLength =TitleMinLength)]
        public string Title { get; set; } = null!;

        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Range(PageNumMinLength,PageNumMaxLength)]
        [Display(Name = "Print length")]
        public int NumberOfPages { get; set; }

        [Display(Name ="Publication date")]
        public DateTime? PublicationDate { get; set; }

        [StringLength(PublisherMaxLength,MinimumLength=PublisherMinLength)]
        public string Publisher { get; set; } = null!;

        [Display(Name ="Image URL")]
        public string ImageUrl { get; set; } = null!;

        public List<GenreModel> Genres { get; set; } = new List<GenreModel>();
        public List<AuthorModel> Authors { get; set; }= new List<AuthorModel>(); 

        public List<int> SelectedAuthors { get; set; } = new List<int>();
        public List<int> SelectedGenres { get; set; } = new List<int>();

    }
}
