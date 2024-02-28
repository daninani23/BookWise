using BookWise.Core.Models.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWise.Core.Models.Author
{
    public class AuthorDetailsModel:AuthorServiceModel
    {
        public DateTime? BirthDate { get; set; }


        public List<BookHomeModel> Books { get; set; } = new List<BookHomeModel>();


        public List<int> SelectedBooks { get; set; } = new List<int>();

    }
}
