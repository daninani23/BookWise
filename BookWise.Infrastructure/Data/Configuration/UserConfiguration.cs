using Microsoft.AspNetCore.Identity;
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
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<User> CreateUsers()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = "admin2856-c198-4129-b3f3-b893d8395082",

                UserName = "admin",

                NormalizedUserName = "ADMIN",

                Email = "admin@mail.com",

                NormalizedEmail = "ADMIN@MAIL.COM",
                FirstName = "Danina",
                LastName = "Ivanova"
            };

            user.PasswordHash =

          hasher.HashPassword(user, "admin123");

            users.Add(user);


            user = new User()

            {

                Id = "gs6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",

                UserName = "guest",

                NormalizedUserName = "GUEST",

                Email = "guest@mail.com",

                NormalizedEmail = "GUEST@GMAIL.COM",
                FirstName = "Teodora",
                LastName = "Apostolova"

            };

            user.PasswordHash =

            hasher.HashPassword(user, "guest123");

            users.Add(user);

            return users;

        }
    }
}
