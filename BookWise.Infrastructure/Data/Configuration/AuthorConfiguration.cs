using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookWise.Infrastructure.Data.Models;

namespace BookWise.Infrastructure.Data.Configuration
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(CreateAuthors());
        }

        private List<Author> CreateAuthors()
        {
            List<Author> authors = new List<Author>()
            {
                new Author()
                {
                    Id=1,
                    FirstName="Rebecca",
                    LastName="Yarros",
                    BirthDate=new DateTime(1981,4,13),
                    ImageUrl="https://api.entangledpublishing.com/storage/authors/author_16672544738496.jpg"
                },
                new Author()
                {
                    Id=2,
                    FirstName="Stephen",
                    LastName="King",
                    BirthDate=new DateTime(1947,9,20),
                    ImageUrl="https://m.media-amazon.com/images/M/MV5BMjA2ODIxNDM4Nl5BMl5BanBnXkFtZTYwMjkzMzU1._V1_FMjpg_UX1000_.jpg"
                },
                new Author()
                {
                    Id=3,
                    FirstName="Emily",
                    LastName="Henry",
                    BirthDate=new DateTime(1993,6,12),
                    ImageUrl="https://images4.penguinrandomhouse.com/author/306512"
                },
                new Author()
                {
                    Id=4,
                    FirstName="Sara",
                    LastName="Forden",
                    BirthDate=new DateTime(1950,5,19),
                    ImageUrl="https://m.media-amazon.com/images/S/amzn-author-media-prod/m4mrdgmu85gfv47i68pc875a7p._SX450_CR0%2C0%2C450%2C450_.jpg"
                },
                new Author()
                {
                    Id=5,
                    FirstName="Jane",
                    LastName="Austen",
                    BirthDate=new DateTime(1775,12,16),
                    ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/CassandraAusten-JaneAusten%28c.1810%29_hires.jpg/800px-CassandraAusten-JaneAusten%28c.1810%29_hires.jpg"
                },
                new Author()
                {
                    Id=6,
                    FirstName="Owen",
                    LastName="King",
                    BirthDate=new DateTime(1977,2,21),
                    ImageUrl="https://owen-king.com/wp-content/uploads/2022/07/owen-king-author2.jpg"
                }
            };

            return authors;

        }
    }
}
