using BookWise.Core.Contracts;
using BookWise.Core.Models.Book;
using BookWise.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;

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
        [Route("Book/ByGenreType/{genre}")]
        public IActionResult ByGenreType(string genre)
        {
            var booksByGenre = this.bookService.ByGenreType(genre);

            return View(booksByGenre);
        }

        [AllowAnonymous]
        public IActionResult All()
        {
            var books = bookService.All();

            return View(books);
        }

        //[Authorize]
        public async Task<IActionResult> Details(int id)
        {
            if ((await bookService.BookExist(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

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
            if ((await bookService.BookExist(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var book =await bookService.Details(id);
           
            return View(new BookModel 
            {
                Title = book.Title,
                ImageUrl = book.ImageUrl,
                Description = book.Description,
                NumberOfPages = book.NumberOfPages,
                PublicationDate = book.PublicationDate,
                Publisher = book.Publisher,
                Genres = (await bookService.AllGenres()).ToList(),
                Authors = (await bookService.AllAuthors()).ToList()
            });
        }

        //[Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, BookModel model)
        {
            if ((await bookService.BookExist(id)) == false)
            {
                ModelState.AddModelError("", "Book does not exist");

                return View(model);
            }

            await bookService.Edit(id, model);
            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
           
            var book = await bookService.Details(id);
            var model = new BookDetailsModel
            {
                Title = book.Title,
                ImageUrl = book.ImageUrl,
                Description = book.Description,
                BookAuthors = book.BookAuthors.ToList(),
                BookGenres=book.BookGenres.ToList(),
            };

            return View(model);
        }
        //[Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int id, BookDetailsModel model)
        {
            var bookIsDeleted = await this.bookService.Delete(id);

            if (!bookIsDeleted)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(All));
        }
    }
  
}
    

