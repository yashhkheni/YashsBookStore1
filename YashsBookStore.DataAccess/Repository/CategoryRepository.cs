using YashsBookStore.DataAccess.Repository.IRepository;
using YashsBookStore.Models;
using YashsBookStore.DataAccess.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace YashsBookStore.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            var objFromDb =_db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
            throw new NotImplementedException();
        }
    }
}
