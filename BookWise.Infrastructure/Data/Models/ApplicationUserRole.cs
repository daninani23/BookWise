using Microsoft.AspNetCore.Identity;

namespace BookWise.Data.Models
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public ApplicationUser User { get; set; }

        public ApplicationRole Role { get; set; }
    }
}
