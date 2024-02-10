using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static BookWise.Infrastructure.Data.DataConstants.User;

namespace BookWise.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            Reviews = new List<Review>();
        }

        [Required, StringLength(MaxName)]
        public string FirstName { get; set; } = null!;

        [Required, StringLength(MaxName)]
        public string LastName { get; set; } = null!;

        public List<Review> Reviews { get; set; }
    }
}
