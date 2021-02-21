using SistemaVenda.Models;
using System.Threading.Tasks;

namespace SistemaVenda.Servico.Interface
{
    public interface IUsuarioServicoApp
    {
        Task<UsuarioViewModel> GetUsuarioAutenticacao(string email, string senha);
    }
}
