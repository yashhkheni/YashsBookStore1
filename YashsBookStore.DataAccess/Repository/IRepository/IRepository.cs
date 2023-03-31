using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace YashsBookStore.DataAccess.Repository.IRepository
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filer = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
            string includeProperties = null
            );
        void Add(T entity);
        void Remove(int id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
