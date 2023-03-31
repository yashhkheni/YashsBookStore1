using YashsBookStore.DataAccess.Repository.IRepository;
using YashsBookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace YashsBookStore.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filer = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }
    }
}
