using Microsoft.EntityFrameworkCore;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Repositorio.Repositorio
{
    public abstract class BaseRepositorioImpl<TEntity> : IBaseRepositorio<TEntity> where TEntity : ClasseBase
    {
        private readonly ApplicationDbContext _dbContext;

        public BaseRepositorioImpl(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync(true);

            return entity;
        }

        public async Task<TEntity> Get(int id) => await _dbContext.Set<TEntity>().AsQueryable().FirstOrDefaultAsync(x => x.Codigo == id);

        public async Task<IEnumerable<TEntity>> GetAll() => await _dbContext.Set<TEntity>().AsQueryable().AsNoTracking().ToListAsync();

        public async Task Remove(TEntity entity)
        {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync(true);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync(true);

            return entity;
        }

        public void Dispose()
        {
        }
    }
}
