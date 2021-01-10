using SistemaVenda.Dominio.Repositorio;
using System;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Servico.Helpers;
using Microsoft.AspNetCore.Http;

namespace SistemaVenda.Servico.Servicos
{
    public class UsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private IHttpContextAccessor _httpContextAccessor;

        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio, IHttpContextAccessor httpContextAccessor)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _httpContextAccessor = httpContextAccessor;
        }

        public Usuario GetUsuario(string email, string senha)
        {
            try
            {
                var senhaMD5hash = Criptografia.GetStringMD5Hash(senha);
                var usuario = _usuarioRepositorio.GetUsuarioAutentication(email, senhaMD5hash);

                if (usuario != null)
                {
                    _httpContextAccessor.HttpContext.Session.SetInt32(Session.CODIGO_USUARIO, usuario.Codigo);
                    _httpContextAccessor.HttpContext.Session.SetString(Session.NOME_USUARIO, usuario.Nome);
                    _httpContextAccessor.HttpContext.Session.SetString(Session.EMAIL_USUARIO, usuario.Email);
                    _httpContextAccessor.HttpContext.Session.SetInt32(Session.LOGADO, 1);
                }

                return usuario;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
