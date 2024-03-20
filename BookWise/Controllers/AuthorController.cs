using BookWise.Core.Contracts;
using BookWise.Core.Models.Author;
using BookWise.Core.Models.Book;
using BookWise.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookWise.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService authorService;

        public AuthorController(IAuthorService _authorService)
        {
            authorService = _authorService;
        }

        [AllowAnonymous]
        public IActionResult All()
        {
            var authors = authorService.All();

            return View(authors);
        }

        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> Add()
        {

            var model = new AuthorDetailsModel()
            {
                Books = (await authorService.AllBooks()).ToList(),
            };

            return View(model);
        }
        //[Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(AuthorDetailsModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                int id = await authorService.Create(model);
                return RedirectToAction(nameof(Details), new { id });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home");
            }
        }

        //[Authorize]
        public async Task<IActionResult> Details(int id)
        {
            if ((await authorService.AuthorExists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var model = await authorService.Details(id);

            model.Books = await authorService.GetBooksByAuthor(id);
            return View(model);
        }

        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await authorService.AuthorExists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var author = await authorService.Details(id);

            return View(new AuthorDetailsModel
            {
                FirstName = author.FirstName,
                LastName = author.LastName,
                ImageUrl = author.ImageUrl,
                BirthDate = author.BirthDate,
                Description=author.Description,
                Books=(await authorService.AllBooks()).ToList()
            });
        }

        //[Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, AuthorDetailsModel model)
        {
            if ((await authorService.AuthorExists(id)) == false)
            {
                ModelState.AddModelError("", "Author does not exist");

                return View(model);
            }

            await authorService.Edit(id, model);
            return RedirectToAction(nameof(Details), new { id });
        }

    }
}
