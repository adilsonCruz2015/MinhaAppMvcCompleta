using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);        

        Task<TEntity> Get(Guid id);

        Task<List<TEntity>> Get();

        Task Add(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(Guid id);        

        Task<int> SaveChanges();
    }
}
