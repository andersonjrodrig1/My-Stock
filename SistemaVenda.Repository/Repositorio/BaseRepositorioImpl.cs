using Microsoft.EntityFrameworkCore;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaVenda.Repositorio.Repositorio
{
    public class BaseRepositorioImpl<TEntity> : IBaseRepositorio<TEntity> where TEntity : ClasseBase
    {
        private readonly ApplicationDbContext _dbContext;

        public BaseRepositorioImpl(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity Add(TEntity entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges(true);

            return entity;
        }

        public TEntity Get(int id) => _dbContext.Set<TEntity>().AsQueryable().FirstOrDefault(x => x.Codigo == id);

        public IEnumerable<TEntity> GetAll() => _dbContext.Set<TEntity>().AsQueryable().AsNoTracking().ToList();

        public void Remove(TEntity entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges(true);
        }

        public TEntity Update(TEntity entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges(true);

            return entity;
        }

        public void Dispose()
        {
        }
    }
}
