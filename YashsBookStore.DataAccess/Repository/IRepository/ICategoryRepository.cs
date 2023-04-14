using YashsBookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace YashsBookStore.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
        void Add(CoverType coverType);
        void Update(CoverType coverType);
    }
}
