using Microsoft.AspNetCore.Mvc;

namespace SOLID.Presentation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    }
}
