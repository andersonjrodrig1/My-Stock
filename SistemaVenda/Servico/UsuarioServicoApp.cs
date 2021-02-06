using SistemaVenda.Dominio.Interface;
using SistemaVenda.Interface;
using SistemaVenda.Models;
using AutoMapper;
using System.Threading.Tasks;

namespace SistemaVenda.Servico
{
    public class UsuarioServicoApp : IUsuarioServicoApp
    {
        private readonly IUsuarioServico _usuarioServico;

        public UsuarioServicoApp(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        public async Task<UsuarioViewModel> GetUsuarioAutenticacao(string email, string senha)
        {
            UsuarioViewModel viewModel = null;

            var usuario = await _usuarioServico.GetUsuarioAutenticacao(email, senha);

            if (usuario != null)
            {
                var configuracao = new MapperConfiguration(conf => conf.CreateMap<SistemaVenda.Dominio.Entidades.Usuario, UsuarioViewModel>());
                var mapeamento = configuracao.CreateMapper();
                viewModel = mapeamento.Map<UsuarioViewModel>(usuario);
            }

            return viewModel;
        }
    }
}
