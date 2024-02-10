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
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(CreateGenres());
        }

        private List<Genre> CreateGenres()
        {
            List<Genre> genres = new List<Genre>()
            {
                new Genre()
                {
                    Id= 1,
                    Name="Fantasy"
                },
                new Genre()
                {
                    Id= 2,
                    Name="Horror"
                },
                new Genre()
                {
                    Id= 3,
                    Name="Biography"
                },
                new Genre()
                {
                    Id= 4,
                    Name="Romance"
                },
                new Genre()
                {
                    Id= 5,
                    Name="Classic"
                }
            };

            return genres;
        }
    }
}
