using BookWise.Core.Contracts;
using BookWise.Core.Models.Book;
using BookWise.Data.Seeding;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookWise.Controllers
{

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

        [Authorize(Roles = GlobalConstants.UserRoleName + "," + GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Details(int id)
        {
            if ((await bookService.BookExist(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }
            var model = await bookService.Details(id);
            model.Authors = await bookService.GetAuthorsByBook(id);
            model.Reviews = await bookService.GetReviewsByBook(id);
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Add()
        {
            var model = new BookModel()
            {
                Genres = (await bookService.AllGenres()).ToList(),
                Authors= (await bookService.AllAuthors()).ToList()   
            };
            return View(model);
        }
        
        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
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

        
        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
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


        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
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
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
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

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Delete(int id, BookDetailsModel model)
        {
            var bookIsDeleted = await this.bookService.Delete(id);

            if (!bookIsDeleted)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> AllF([FromQuery]AllBooksQueryModel query) 
        {
            var result = await bookService.AllF(query.Genre, query.SearchTerm,query.CurrentPage,AllBooksQueryModel.BooksPerPage);

            query.TotalBooksCount = result.TotalBooksCount;
            query.Genres = await bookService.AllGenresNames();
            query.Books = result.Books;

            return View(query);   
        }
    }
  
}
    

