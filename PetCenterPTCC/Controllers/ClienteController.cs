using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetCenterPTCC.Data; // IMPORTANTE
using PetCenterPTCC.Models; // se precisar

namespace PetCenterPTCC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly PetContext _context;

        public ClienteController(PetContext context)
        {
            _context = context;
        }

        public IActionResult CadastroCliente()
        {
            return View();
        }

        // GET → abre a tela de login
        public IActionResult LoginCliente()
        {
            return View();
        }

        // POST → recebe os dados do formulário
        [HttpPost]
        public IActionResult LoginCliente(string nome, string email, string senha)
        {
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Nome == nome && u.Email == email && u.Senha == senha);

            if (usuario == null)
            {
                ViewBag.Erro = "Usuário não encontrado. Verifique os dados.";
                return View(); // volta pra tela
            }

            return RedirectToAction("Index", "Home");
        }
    }

}
