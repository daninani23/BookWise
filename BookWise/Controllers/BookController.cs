using BookWise.Core.Contracts;
using BookWise.Core.Models.Book;
using BookWise.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookWise.Controllers
{
    //[Authorize]
    public class BookController : Controller
    {
        private readonly IBookService bookService;

        public BookController(IBookService _bookService)
        {
            bookService = _bookService;
        }

        [AllowAnonymous]
        public IActionResult All()
        {
            var books = bookService.All();

            return View(books);
        }

        //[Authorize]
        public async Task<IActionResult> Mine()
        {
            var model = new BookServiceModel();
            return View(model);
        }

        //[Authorize]
        public async Task<IActionResult> Details(int id)
        {
            
            var model = await bookService.Details(id);
            return View(model);
        }

        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new BookModel()
            {
                Genres = (await bookService.AllGenres()).ToList(),
                Authors= (await bookService.AllAuthors()).ToList()   
            };
            return View(model);
        }
        //[Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(BookModel model)
        {
            if (!ModelState.IsValid) 
            { 
                return View(model);
            }
            try
            {
                int id = await bookService.Create(model);
                return RedirectToAction(nameof(Details), new { id });
            }
            catch (Exception ex) 
            {
                return RedirectToAction("Error", "Home");
            }
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
    

