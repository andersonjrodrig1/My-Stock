using SistemaVenda.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaVenda.Servico.Interface
{
    public interface ICategoriaServicoApp
    {
        Task SaveCategoria(CategoriaViewModel categoria);
        Task<IEnumerable<CategoriaViewModel>> GetCategorias();
        Task<CategoriaViewModel> GetCategoria(int codigoCategoria);
    }
}
