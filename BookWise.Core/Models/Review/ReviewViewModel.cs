using BookWise.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWise.Core.Models.Review
{
    public class ReviewViewModel:ReviewFormModel
    {
        public ApplicationUser User { get; set; }
    }
}
