using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWise.Core.Models.Book
{
    public class BookDetailsModel:BookServiceModel
    {
        public int NumberOfPages { get; set; }

        public DateTime? PublicationDate { get; set; }

        public string Publisher { get; set; } = null!;

        public int ReviewsCount { get; set; }
        public double Rating { get; set; }
        //new
        public List<AuthorModel> Authors { get; set; } = new List<AuthorModel>();

    }
}
