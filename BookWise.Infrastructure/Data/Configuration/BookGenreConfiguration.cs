using BookWise.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWise.Infrastructure.Data.Configuration
{
    internal class BookGenreConfiguration : IEntityTypeConfiguration<BookGenre>
    {
        public void Configure(EntityTypeBuilder<BookGenre> builder)
        {
            builder.HasData(CreateBookGenres());
        }

        private List<BookGenre> CreateBookGenres()
        {
            List<BookGenre> bookGenres = new List<BookGenre>()
            {
                new BookGenre()
                {
                    BookId=1,
                    GenreId=1,
                },
                new BookGenre()
                {
                    BookId=1,
                    GenreId=4,
                },
                new BookGenre()
                {
                    BookId=2,
                    GenreId=2,
                },
                new BookGenre()
                {
                    BookId=3,
                    GenreId=4,
                },
                new BookGenre()
                {
                    BookId=4,
                    GenreId=3,
                },
                new BookGenre()
                {
                    BookId=5,
                    GenreId=4,
                },
                new BookGenre()
                {
                    BookId=5,
                    GenreId=5,
                },
                new BookGenre()
                {
                    BookId=6,
                    GenreId=2,
                }
            };

            return bookGenres;
        }
    }
}
