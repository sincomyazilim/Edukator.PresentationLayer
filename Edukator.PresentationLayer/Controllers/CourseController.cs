using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edukator.BusinessLayer.Abstract;

namespace Edukator.PresentationLayer.Controllers
{
    public class CourseController : Controller
    {//12
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        //-----------------------------
        public IActionResult Index()
        {
            var values = _courseService.BGetList();
            return View(values);
        }
    }
}
