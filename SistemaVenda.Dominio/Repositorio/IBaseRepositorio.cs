using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Repositorio
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        Task<TEntity> Get(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task Remove(TEntity entity);
    }
}
