using SistemaVenda.Dominio.Interface;
using SistemaVenda.Interface;
using SistemaVenda.Models;
using System;

namespace SistemaVenda.Servico
{
    public class UsuarioServicoApp : IUsuarioServicoApp
    {
        private readonly IUsuarioServico _usuarioServico;

        public UsuarioServicoApp(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        public UsuarioViewModel GetUsuarioAutenticacao(string email, string senha)
        {
            var usuario = _usuarioServico.GetUsuarioAltenticacao(email, senha);

            //TODO: verificar plugin de mapeamento
            return new UsuarioViewModel()
            {
                Codigo = usuario.Codigo,
                Email = usuario.Email,
                Nome = usuario.Nome,
                Senha = string.Empty
            };
        }
    }
}
