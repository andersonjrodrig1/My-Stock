using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Interface
{
    public interface ICategoriaServico
    {
        Task SaveCategoria(Categoria categoria);
        Task<IEnumerable<Categoria>> GetCategorias();
    }
}
