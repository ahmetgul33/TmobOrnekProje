using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WebProjesiDataAccess.Abstract;

namespace WebProjesiPosData.Abstract
{
   public interface IRepository<T> where T : class, IEntity, new()
    {

        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
