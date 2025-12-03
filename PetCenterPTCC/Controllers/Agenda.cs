using Microsoft.AspNetCore.Mvc;

namespace PetCenterPTCC.Controllers
{
    public class Agenda : Controller
    {
        public IActionResult NossaAgenda()
        {
            return View();
        }
    }
}
