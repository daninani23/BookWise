namespace BookWise.Core.Models.Review
{
    public class ReviewFormModel
    {
        public string ReviewText { get; set; } = null!;

        public int Rating { get; set; }

        public int BookId { get; set; }

        public string BookImage { get; set; } = null!;
        public string BookTitle { get; set; } = null!;

    }
}
