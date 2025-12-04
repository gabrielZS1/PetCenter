using Microsoft.AspNetCore.Mvc;

namespace PetCenterPTCC.Controllers
{
    public class Loja : Controller
    {
        public IActionResult LojaPet()
        {
            return View();
        }
    }
}