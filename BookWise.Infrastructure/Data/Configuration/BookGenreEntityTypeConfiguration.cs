using BookWise.Data.Models;
using BookWise.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWise.Data.Configuration
{
    public class BookGenreEntityTypeConfiguration : IEntityTypeConfiguration<BookGenre>
    {
        public void Configure(EntityTypeBuilder<BookGenre> builder) 
        {
            builder.HasKey(x => new { x.BookId, x.GenreId });
            
        }
    }
}
