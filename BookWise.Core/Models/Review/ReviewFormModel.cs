using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWise.Core.Models.Review
{
    public  class ReviewFormModel
    {
        public string ReviewText { get; set; } = null!;

        public int BookId { get; set; }
    }
}
