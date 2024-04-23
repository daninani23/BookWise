using BookWise.Core.Contracts;
using BookWise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            var model = await bookService.LastFourBooks();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404)
            {
                return View("Error404");
            }

            else if (statusCode == 500)
            {
                return View("Error500");
            }
            else 
            {
                return View("Error");
            }

            return View();
        }
    }
}