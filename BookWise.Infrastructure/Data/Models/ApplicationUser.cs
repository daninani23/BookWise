using BookWise.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using static BookWise.Infrastructure.Data.DataConstants.User;

namespace BookWise.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Reviews = new HashSet<Review>();
            UserRoles = new HashSet<ApplicationUserRole>();
        }

        [Required, StringLength(MaxName)]
        public string FirstName { get; set; } = null!;

        [Required, StringLength(MaxName)]
        public string LastName { get; set; } = null!;

        public ICollection<Review> Reviews { get; set; }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }




    }
}
