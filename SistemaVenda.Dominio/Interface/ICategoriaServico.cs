using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Dominio.Interface
{
    public interface ICategoriaServico
    {
        Categoria SaveCategoria(Categoria categoria);
        IEnumerable<Categoria> GetCategorias();
    }
}
