using Microsoft.AspNetCore.Mvc;

namespace PetCenterPTCC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Abre Views/Home/Index.cshtml
        }

        public IActionResult Privacy()
        {
            return View(); // Abre Views/Home/Privacy.cshtml
        }
    }
}