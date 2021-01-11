using SistemaVenda.Dominio.Repositorio;
using System;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Servico.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace SistemaVenda.Servico.Servicos
{
    public class UsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private IHttpContextAccessor _httpContextAccessor;
        private ILogger _logger;

        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio, IHttpContextAccessor httpContextAccessor, ILogger<UsuarioServico> logger)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
        }

        public Usuario GetUsuario(string email, string senha)
        {
            try
            {
                _logger.LogInformation("Validando senha informada pelo usuário.");

                var senhaMD5hash = Criptografia.GetStringMD5Hash(senha);

                _logger.LogInformation($"Busca do usuário com email: {email} para autenticação.");

                var usuario = _usuarioRepositorio.GetUsuarioAutentication(email, senhaMD5hash);

                if (usuario != null)
                {
                    _logger.LogInformation("Adicionando informações do usuário na sessão.");

                    _httpContextAccessor.HttpContext.Session.SetInt32(Session.CODIGO_USUARIO, usuario.Codigo);
                    _httpContextAccessor.HttpContext.Session.SetString(Session.NOME_USUARIO, usuario.Nome);
                    _httpContextAccessor.HttpContext.Session.SetString(Session.EMAIL_USUARIO, usuario.Email);
                    _httpContextAccessor.HttpContext.Session.SetInt32(Session.LOGADO, 1);
                }

                return usuario;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao autenticar usuário. Detalhes: {ex.Message}");
                throw;
            }
        }
    }
}
