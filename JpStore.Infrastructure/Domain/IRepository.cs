using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace JpStore.Infrastructure.Domain
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> FindAll();
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter);
        IQueryable<TEntity> Get(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, List<Expression<Func<TEntity, object>>> includeProperties, int? page, int? pageSize);
        TEntity FindById(object id);
        void Add(TEntity newEntity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
