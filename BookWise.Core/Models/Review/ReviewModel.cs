using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWise.Core.Models.Review
{
    public class ReviewModel 
    {
        public string ReviewText { get; set; } = null!;

        public int Rating { get; set; }

        public int BookId { get; set; }
    }
}
