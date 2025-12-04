using Microsoft.AspNetCore.Mvc;

namespace PetCenterPTCC.Controllers
{
    public class PetController : Controller
    {
        // URL: /Pet/CadastrarPet
        public IActionResult CadastrarPet()
        {
            return View();
        }
    }
}