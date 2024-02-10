using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static BookWise.Infrastructure.Data.DataConstants.Genre;

namespace BookWise.Infrastructure.Data.Models
{
    public class Genre
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(MaxName)]
        public string Name { get; set; } = null!;

        public List<BookGenre> BookGenres { get; set; } = new List<BookGenre>();
    }
}
