using SistemaVenda.Dominio.Entidades;

namespace SistemaVenda.Dominio.Repositorio
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario GetUsuarioAutentication(string email, string senha);
    }
}
