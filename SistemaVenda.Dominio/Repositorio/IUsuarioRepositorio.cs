using SistemaVenda.Dominio.Entidades;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Repositorio
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Task<Usuario> GetUsuarioAutentication(string email, string senha);
    }
}
