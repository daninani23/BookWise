using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BookWise.Data.Models;
using BookWise.Infrastructure.Data.Models;

namespace BookWise.Data.Configuration
{
    public class ReviewEntityTypeConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasOne(r => r.User)
                   .WithMany(u => u.Reviews)
                   .HasForeignKey(r => r.UserId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(r => r.Book)
                   .WithMany(b => b.Reviews)
                   .HasForeignKey(r => r.BookId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
