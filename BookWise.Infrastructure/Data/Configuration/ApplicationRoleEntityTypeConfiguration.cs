using BookWise.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BookWise.Data.Configuration
{
    public class ApplicationRoleEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasMany(e => e.UserRoles)
                 .WithOne(e => e.Role)
                 .HasForeignKey(ur => ur.RoleId)
                 .IsRequired();
        }
    }
}
