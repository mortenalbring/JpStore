using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JpStore.Services
{
    public interface IBaseService<EntityT> where EntityT : class
    {
        void Insert(EntityT entity);
        void Update(EntityT entity);
        void Delete(EntityT entity);
    }
}
