﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YashsBookStore.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository Cover { get; }

        ISP_Call SP_Call { get; }


        void Save();
    }
}