using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Dominio.Helpers;
using SistemaVenda.Servico.Interface;
using SistemaVenda.Models;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            ViewData["ErroLogin"] = string.Empty;

            if (ModelState.IsValid)
            {
                var usuario = await _usuarioServicoApp.GetUsuarioAutenticacao(model.Email, model.Senha);

                if (usuario == null)
                {
                    ViewData["ErroLogin"] = "Email e/ou Senha inválidos!";

                    return View();
                }

                _httpContextAccessor.HttpContext.Session.SetInt32(Session.CODIGO_USUARIO, usuario.Codigo);
                _httpContextAccessor.HttpContext.Session.SetString(Session.NOME_USUARIO, usuario.Nome);
                _httpContextAccessor.HttpContext.Session.SetString(Session.EMAIL_USUARIO, usuario.Email);
                _httpContextAccessor.HttpContext.Session.SetInt32(Session.LOGADO, 1);

                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
