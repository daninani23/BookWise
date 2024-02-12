using BookWise.Core.Models.Book;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookWise.Controllers
{
    //[Authorize]
    public class BookController : Controller
    {
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = new BooksQueryModel();
            return View(model);
        }

        //[Authorize]
        public async Task<IActionResult> Mine()
        {
            var model = new BooksQueryModel();
            return View(model);
        }

        //[Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var model = new BookDetailsModel();
            return View(model);
        }

        //[Authorize]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        //[Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(BookModel model)
        {
            int id = 1;
            return RedirectToAction(nameof(Details), new { id });
        }

        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = new BookModel();
            return View();
        }

        //[Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, BookModel model)
        {
            return RedirectToAction(nameof(Details), new { id });
        }
        //[Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            return RedirectToAction(nameof(All));
        }

    } 

}
    

