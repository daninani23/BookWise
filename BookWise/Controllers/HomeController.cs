using BookWise.Core.Contracts;
using BookWise.Core.Models.Book;
using Microsoft.AspNetCore.Mvc;

namespace BookWise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService bookService;


        public HomeController(ILogger<HomeController> logger, IBookService _bookService)
        {
            _logger = logger;
            bookService = _bookService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<BookHomeModel> model;

            try
            {
                model = await bookService.LastFourBooks();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404)
            {
                return View("Error404");
            }

            if (statusCode == StatusCodes.Status500InternalServerError)
            {
                return View("Error500");
            }

            return View();
        }
    }
}