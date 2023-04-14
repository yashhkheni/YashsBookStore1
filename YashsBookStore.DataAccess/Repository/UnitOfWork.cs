﻿using YashsBookStore.DataAccess.Repository;
using YashsBookStore.DataAccess.Repository.IRepository;
using YashsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace YashsBookStore.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork //make the method public to access the class
    {
        private readonly ApplicationDbContext _db; //the using statement
        public UnitOfWork(ApplicationDbContext db)// constructor to use DI and inject in to the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }

        public ISP_Call SP_Call { get; private set; }
        

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();//All the changes will be saved when the save methods is called at the parent leave.
        }
    }
}