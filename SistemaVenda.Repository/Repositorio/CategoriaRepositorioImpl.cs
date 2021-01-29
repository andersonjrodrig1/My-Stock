using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Repositorio.Repositorio
{
    public class CategoriaRepositorioImpl : BaseRepositorioImpl<Categoria>, ICategoriaRepositorio
    {
        public CategoriaRepositorioImpl(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
