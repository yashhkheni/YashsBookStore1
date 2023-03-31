using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YashsBookStore.DataAccess.Repository;
using YashsBookStore.DataAccess.Repository.IRepository;


namespace YashsBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(UnitOfWork unitOfWork)
        {
            _unitOfWork = (IUnitOfWork)unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        // API Call
    }
}