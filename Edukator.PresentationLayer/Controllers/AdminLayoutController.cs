using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class AdminLayoutController : Controller
    {//12
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PartialHead()
        {
            return PartialView();
        }
        public IActionResult PartialSpiner()
        {
            return PartialView();
        }
        public IActionResult PartialsideBar()
        {
            return PartialView();
        }
        public IActionResult PartialNavbar()
        {
            return PartialView();
        }


        public IActionResult PartialFooter()
        {
            return PartialView();
        }
        public IActionResult PartialScript()
        {
            return PartialView();
        }
    }
}
