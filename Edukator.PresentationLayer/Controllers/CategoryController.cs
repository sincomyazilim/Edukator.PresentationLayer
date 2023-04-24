using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edukator.DataAccessLayer.Abstract;
using Edukator.BusinessLayer.Abstract;

namespace Edukator.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {//11
        private readonly ICategoryService _categoryservice;

        public CategoryController(ICategoryService categoryservice)
        {
            _categoryservice = categoryservice;
        }
        //---------------------------------------------------
        public IActionResult Index()
        {
            var values = _categoryservice.BGetList();
            return View(values);

          
        }
    }
}
