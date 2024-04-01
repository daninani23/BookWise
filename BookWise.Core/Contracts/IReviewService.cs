using BookWise.Core.Models.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWise.Core.Contracts
{
    public interface IReviewService
    {
        Task<int> CreateAsync(ReviewFormModel model, int bookid, string userId);
    }
}
