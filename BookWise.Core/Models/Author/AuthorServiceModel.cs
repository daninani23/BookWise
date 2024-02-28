using BookWise.Core.Models.Book;
using BookWise.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static BookWise.Infrastructure.Data.DataConstants.Author;

namespace BookWise.Core.Models.Author
{
    public class AuthorServiceModel
    {
        [Required(ErrorMessage = "Аuthor's first name is required.")]
        [StringLength(MaxName, MinimumLength = MinName, ErrorMessage = "First name should be between {2} and {1} characters long.")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Аuthor's last name is required.")]
        [StringLength(MaxName, MinimumLength = MinName, ErrorMessage = "Last name should be between {2} and {1} characters long.")]
        public string LastName { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

    }
}
