using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWise.Core.Models.Book
{
    public class BookQueryServiceModel
    {
        public int TotalBooksCount { get; set; }

        public IEnumerable<BookServiceModel> Books { get; set; } = new List<BookServiceModel>();
    }
}
