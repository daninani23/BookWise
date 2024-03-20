using BookWise.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BookWise.Data.Configuration
{
    public class ApplicationUserEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasMany(e => e.UserRoles)
                 .WithOne(e => e.User)
                 .HasForeignKey(ur => ur.UserId)
                 .IsRequired();
        }
    }
}
