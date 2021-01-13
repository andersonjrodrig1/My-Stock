using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Interface;
using SistemaVenda.Models;

namespace SistemaVenda.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioServicoApp _usuarioServicoApp;
        private IHttpContextAccessor _httpContextAccessor;

        public LoginController(IUsuarioServicoApp usuarioServicoApp, IHttpContextAccessor httpContextAccessor)
        {
            _usuarioServicoApp = usuarioServicoApp;
            _httpContextAccessor = httpContextAccessor;
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
                var usuario = _usuarioServicoApp.GetUsuarioAutenticacao(model.Email, model.Senha);

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
