using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Interface
{
    public interface IProdutoService : IDisposable
    {
        Task<IEnumerable<Produto>> GetProdutos();
    }
}
