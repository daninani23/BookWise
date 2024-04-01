using BookWise.Data.Seeding;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookWise.Controllers
{
    public class GenreController:Controller
    {  
        public IActionResult All()
        {
            return View();
        }
    }
}
