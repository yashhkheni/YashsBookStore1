﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using YashsBookStore.DataAccess.Data;
using YashsBookStore.DataAccess.Repository.IRepository;
using YashsBookStore.Models;

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
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            
            }
        }
    }
}
