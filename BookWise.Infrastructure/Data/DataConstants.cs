using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWise.Infrastructure.Data
{
    public class DataConstants
    {
        public class Book
        {
            public const int TitleMaxLength = 55;
            public const int TitleMinLength = 5;
            public const int DescriptionMaxLength = 1500;
            public const int DescriptionMinLength = 200;
            public const int PublisherMaxLength = 45;
            public const int PublisherMinLength = 5;
            public const int PageNumMaxLength = 1100;
            public const int PageNumMinLength = 5;
        }

        public class Review
        {
            public const int MaxText = 1000;
            public const int MinText = 50;
            public const int MaxRating = 5;
            public const int MinRating = 1;
        }

        public class Author
        {
            public const int MaxName = 40;
            public const int MinName = 3;
            public const int DescriptionMaxLength = 1500;
            public const int DescriptionMinLength = 200;
        }

        public class Genre
        {
            public const int MaxName = 40;
            public const int MinName = 3;
        }

        public class User
        {
            public const int MaxName = 40;
            public const int MinName = 3;
        }

        public class Role 
        {
            public const string AdministratorRoleName = "Administrator";

            public const string UserRoleName = "User";
        }
    }
}
