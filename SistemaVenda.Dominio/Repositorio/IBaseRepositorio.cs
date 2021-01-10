using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Dominio.Repositorio
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
