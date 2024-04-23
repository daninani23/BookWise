using BookWise.Core.Contracts;
using BookWise.Core.Models.Review;
using BookWise.Data.Seeding;
using BookWise.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookWise.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewService reviewService;

        public ReviewController(IReviewService _reviewService)
        {
            reviewService = _reviewService;

        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.UserRoleName)]
        public IActionResult Add()
        {
            var model = new ReviewFormModel();
            

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.UserRoleName)]
        public async Task<IActionResult> Add(ReviewFormModel model,int bookid)
        {
           
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                var userId = User.Id();
                int id = await reviewService.CreateAsync(model,bookid,userId);
                return RedirectToAction("Details", "Book", new { id = bookid });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home");
            
             }
        
        }

        
    }
}
