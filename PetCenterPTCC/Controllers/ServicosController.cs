using Microsoft.AspNetCore.Mvc;

namespace PetCenterPTCC.Controllers
{
    public class ServicosController : Controller
    {
        // URL: /Servicos/NossosServicos
        public IActionResult NossosServicos()
        {
            return View();
        }
    }
}