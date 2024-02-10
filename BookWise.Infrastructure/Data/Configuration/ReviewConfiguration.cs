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
    internal class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(CreateReviews());
        }

        private List<Review> CreateReviews()
        {
            List<Review> reviews = new List<Review>()
            {
                new Review()
                {
                    Id=1,
                    UserId="gs6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    BookId=1,
                    Rating=5,
                    ReviewText="i hate to admit it, but the hype is real. i wasnt sure i could trust all of the praise this book is getting because i didnt like the last RY book that was widely loved. but this one is enjoyable!it has all of your typical fantasy tropes - a girl who doesnt know her powerful potential, found families, a magical enemy threatening the kingdom, and enemies to lovers. so nothing about this is super unique. but everything is done really well and is very engaging.this is just one of those books that is a lot of fun to read. so you dont really care about how well its written or the bigger points reviewers usually critique. its just about pure enjoyment.so if you like dragons and youre looking for a new fantasy read with a decent amount of romance, this is the one for you!"
                }
            };
            return reviews;
        }
    }
}
