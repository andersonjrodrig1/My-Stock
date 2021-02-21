using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Repositorio.Repositorio
{
    public class ProdutoRepositorioImpl : BaseRepositorioImpl<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorioImpl(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
