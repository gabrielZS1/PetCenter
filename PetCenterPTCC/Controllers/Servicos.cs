using Microsoft.AspNetCore.Mvc;

namespace PetCenterPTCC.Controllers
{
    public class Servicos : Controller
    {
        public IActionResult NossosServicos()
        {
            return View();
        }
    }
}
