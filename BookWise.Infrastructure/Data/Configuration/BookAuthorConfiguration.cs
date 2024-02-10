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
    internal class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasData(CreateBookAuthors());
        }

        private List<BookAuthor> CreateBookAuthors()
        {
            List<BookAuthor> bookauthors = new List<BookAuthor>()
            {
                new BookAuthor()
                {
                    BookId=1,
                    AuthorId=1,
                },
                new BookAuthor()
                {
                    BookId=2,
                    AuthorId=2,
                },
                new BookAuthor()
                {
                    BookId=3,
                    AuthorId=3,
                },
                new BookAuthor()
                {
                    BookId=4,
                    AuthorId=4,
                },
                new BookAuthor()
                {
                    BookId=5,
                    AuthorId=5,
                },
                new BookAuthor()
                {
                    BookId=6,
                    AuthorId=6,
                },
                new BookAuthor()
                {
                    BookId=6,
                    AuthorId=2,
                },

            };

            return bookauthors;
        }
    }
}
