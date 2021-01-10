using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Models;
using SistemaVenda.Servico.Servicos;
using SistemaVenda.Servico.Helpers;

namespace SistemaVenda.Controllers
{
    public class LoginController : Controller
    {
        private readonly UsuarioServico _usuarioServico;
        private IHttpContextAccessor _httpContextAccessor;

        public LoginController(UsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        public IActionResult Index(int? id)
        {
            if (id.HasValue && id.Value == 0)
            {
                _httpContextAccessor.HttpContext.Session.Clear();
            }

            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            ViewData["ErroLogin"] = string.Empty;

            if (ModelState.IsValid)
            {
                var usuario = _usuarioServico.GetUsuario(model.Email, model.Senha);

                if (usuario == null)
                {
                    ViewData["ErroLogin"] = "Email e/ou Senha inválidos!";

                    return View();
                }

                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
