using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookWise.Infrastructure.Data.DataConstants.Review;
using System.Xml.Linq;

namespace BookWise.Infrastructure.Data.Models
{
    public class Review
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required, StringLength(MaxText)]
        public string ReviewText { get; set; } = null!;

        [Required, Range(MinRating, MaxRating)]
        public int Rating { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [Required]
        public int BookId { get; set; }

        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; } = null!;
    }
}
