using SistemaVenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Interface
{
    public interface ICategoriaServicoApp
    {
        Task SaveCategoria(CategoriaViewModel categoria);
        Task<IEnumerable<CategoriaViewModel>> GetCategorias();
    }
}
