using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetCenterPTCC.Data;
using PetCenterPTCC.Models;

namespace PetCenterPTCC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly PetContext _context;

        public ClienteController(PetContext context)
        {
            _context = context;
        }

       
        //  CADASTRO 
        
        public IActionResult CadastroCliente()
        {
            return View();
        }

        
        //  CADASTRO 
        
        [HttpPost]
        public IActionResult CadastroCliente(string nome, string email, string senha)
        {
            // Verifica se o email já existe
            var usuarioExistente = _context.Usuarios
                .FirstOrDefault(u => u.Email == email);

            if (usuarioExistente != null)
            {
                ViewBag.Erro = "Já existe um usuário cadastrado com esse email!";
                return View();
            }

            // Cria o novo usuário
            var novoUsuario = new Usuario
            {
                Nome = nome,
                Email = email,
                Senha = senha
            };

            _context.Usuarios.Add(novoUsuario);
            _context.SaveChanges();

            ViewBag.Sucesso = "Cadastro realizado com sucesso!";
            return View();
        }


        
        //  LOGIN (GET)
        
        public IActionResult LoginCliente()
        {
            return View();
        }

        
        //  LOGIN (POST)
        
        [HttpPost]
        public IActionResult LoginCliente(string nome, string email, string senha)
        {
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Nome == nome && u.Email == email && u.Senha == senha);

            if (usuario == null)
            {
                ViewBag.Erro = "Usuario inexistente. Verifique os dados.";
                return View();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
