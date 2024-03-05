using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using static BookWise.Infrastructure.Data.DataConstants.User;

namespace BookWise.Models.Account
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string UserName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(60, MinimumLength = 5)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(20, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;


        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;


        [Required(ErrorMessage = "First name field is required.")]
        [Range(MinName, MaxName, ErrorMessage = "First name should be between {1} and {2} characters long.")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Last name field is required.")]
        [Range(MinName, MaxName, ErrorMessage = "Last name should be between {1} and {2} characters long.")]
        public string LastName { get; set; } = null!;
    }
}
