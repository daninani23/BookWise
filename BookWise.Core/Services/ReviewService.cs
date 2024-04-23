using BookWise.Core.Contracts;
using BookWise.Core.Models.Review;
using BookWise.Data.Models;
using BookWise.Infrastructure.Data.Common;
using BookWise.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWise.Core.Services
{
    public  class ReviewService:IReviewService
    {
        private readonly IRepository repo;

        public ReviewService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<int> CreateAsync(ReviewFormModel model, int bookid, string userId)
        {
            var review = new Review()
            {
                ReviewText = model.ReviewText,
                Rating = model.Rating,
                UserId = userId,
                BookId = bookid
            };
            
            var book = await repo.All<Book>()
                .Include(b => b.Reviews)
            .FirstOrDefaultAsync(b => b.Id == bookid);

            if (book != null)
            {
            book.Reviews.Add(review);
            }

            var user = await repo.All<ApplicationUser>()
                .Include(b => b.Reviews)
                .FirstOrDefaultAsync(u => u.Id == userId);


            if (user != null)
            {
              user.Reviews.Add(review);
            }
            await repo.AddAsync(review);
            await repo.SaveChangesAsync();

            return review.Id;
        }

        public async Task<Book> GetBookByIdAsync(int bookid) 
        {
            return await repo.GetByIdAsync<Book>(bookid);
        }
    }
}
