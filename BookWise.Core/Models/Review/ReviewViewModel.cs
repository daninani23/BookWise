using BookWise.Data.Models;

namespace BookWise.Core.Models.Review
{
    public class ReviewViewModel : ReviewModel
    {
        public ApplicationUser User { get; set; }
    }
}
