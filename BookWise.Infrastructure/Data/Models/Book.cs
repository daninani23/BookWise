using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookWise.Infrastructure.Data.DataConstants.Book;

namespace BookWise.Infrastructure.Data.Models
{
    public class Book
    {
        public Book()
        {
            Reviews = new List<Review>();
        }

        [Key]
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required, MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required, Range(PageNumMinLength, PageNumMaxLength)]
        public int NumberOfPages { get; set; }
        public DateTime? PublicationDate { get; set; }

        [Required, MaxLength(PublisherMaxLength)]
        public string Publisher { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public List<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
        public List<BookGenre> BookGenres { get; set; } = new List<BookGenre>();

        public List<Review> Reviews { get; set; }

    }
}
