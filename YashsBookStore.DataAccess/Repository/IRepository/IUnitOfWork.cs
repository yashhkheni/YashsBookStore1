using System;
using System.Collections.Generic;
using System.Text;

namespace YashsBookStore.DataAccess.Repository.IRepository
{
    interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}
