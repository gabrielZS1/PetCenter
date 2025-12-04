using Microsoft.AspNetCore.Mvc;

namespace PetCenterPTCC.Controllers
{
    public class FaleConoscoController : Controller
    {
        // URL: /FaleConosco/faleConosco
        public IActionResult faleConosco()
        {
            return View();
        }
    }
}