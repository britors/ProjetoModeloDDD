using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity GetById(int Id);
        IEnumerable<TEntity> GetAll();
        TEntity Add(TEntity entity);
        void Modify(TEntity entity);
        void Remove(TEntity entity);
        void Dispose();
    }
}
