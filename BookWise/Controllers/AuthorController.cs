using BookWise.Core.Contracts;
using BookWise.Core.Models.Author;
using BookWise.Data.Seeding;
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


        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Add()
        {

            var model = new AuthorDetailsModel()
            {
                Books = (await authorService.AllBooks()).ToList(),
            };

            return View(model);
        }
 
        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
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

        [Authorize(Roles = GlobalConstants.UserRoleName + "," + GlobalConstants.AdministratorRoleName)]
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

        
        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
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

      
        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
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
