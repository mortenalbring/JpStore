using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JpStore.Infrastructure.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
    }
}
