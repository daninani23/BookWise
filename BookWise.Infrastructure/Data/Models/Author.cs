using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static BookWise.Infrastructure.Data.DataConstants.Author;

namespace BookWise.Infrastructure.Data.Models
{
    public class Author
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(MaxName)]
        public string FirstName { get; set; } = null!;

        [Required, MaxLength(MaxName)]
        public string LastName { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public DateTime? BirthDate { get; set; }

        public List<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
    }
}
