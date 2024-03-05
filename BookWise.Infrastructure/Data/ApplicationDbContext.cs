using BookWise.Infrastructure.Data.Configuration;
using BookWise.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookWise.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BookGenre>()
                .HasKey(x => new { x.BookId, x.GenreId });
            builder.Entity<BookAuthor>()
                .HasKey(x => new { x.BookId, x.AuthorId });

            builder.Entity<Models.Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Models.Review>()
                .HasOne(b => b.Book)
                .WithMany(r => r.Reviews)
                .HasForeignKey(b => b.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new ReviewConfiguration());
            builder.ApplyConfiguration(new BookAuthorConfiguration());
            builder.ApplyConfiguration(new BookGenreConfiguration());
            builder.ApplyConfiguration(new IdentityRolesConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<BookAuthor> BookAuthors { get; set; } = null!;
        public DbSet<BookGenre> BookGenres { get; set; } = null!;
    }
}