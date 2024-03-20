using Microsoft.AspNetCore.Identity;

namespace BookWise.Data.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
            : this(null)
        {
            this.UserRoles = new HashSet<ApplicationUserRole>();
        }

        public ApplicationRole(string roleName)
            : base(roleName)
        {
        }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
