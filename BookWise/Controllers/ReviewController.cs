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
        private readonly IBookService bookService;

        public ReviewController(IReviewService _reviewService, IBookService _bookService)
        {
            reviewService = _reviewService;
            bookService = _bookService;

        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.UserRoleName)]
        public async Task<IActionResult> Add(int bookid)
        {
            var model = new ReviewFormModel();

            var book = await reviewService.GetBookByIdAsync(bookid);

            if (book != null)
            {
                model.BookImage=book.ImageUrl; 
                model.BookTitle=book.Title;

            }
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.UserRoleName)]
        public async Task<IActionResult> Add(ReviewModel model,int bookid)
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
