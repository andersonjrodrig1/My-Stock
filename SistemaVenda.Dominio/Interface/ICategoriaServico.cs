using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Interface
{
    public interface ICategoriaServico
    {
        Task<IEnumerable<Categoria>> GetCategorias();
        Task<Categoria> GetCategoria(int codigoCategoria);
        Task SaveCategoria(Categoria categoria);
        Task EditarCategoria(Categoria categoria);
    }
}
