using Microsoft.AspNetCore.Mvc;

namespace PetCenterPTCC.Controllers
{
    public class ClienteController : Controller
    {
        // URL: /Cliente/CadastroCliente
        public IActionResult CadastroCliente()
        {
            return View();
        }

        // URL: /Cliente/LoginCliente
        public IActionResult LoginCliente()
        {
            return View();
        }
    }
}