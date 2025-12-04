using Microsoft.AspNetCore.Mvc;

namespace PetCenterPTCC.Controllers
{
    public class AgendaController : Controller
    {
        // URL: /Agenda/NossaAgenda
        public IActionResult NossaAgenda()
        {
            return View();
        }
    }
}