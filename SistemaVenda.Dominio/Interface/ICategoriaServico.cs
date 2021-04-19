using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Interface
{
    public interface ICategoriaServico : IDisposable
    {
        Task<IEnumerable<Categoria>> GetCategorias();
        Task<Categoria> GetCategoria(int codigoCategoria);
        Task<Categoria> SaveCategoria(Categoria categoria);
        Task<Categoria> EditarCategoria(Categoria categoria);
    }
}
