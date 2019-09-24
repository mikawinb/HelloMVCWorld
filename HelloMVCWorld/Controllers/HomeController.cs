using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// https://asp.mvc-tutorial.com/getting-started/creating-a-controller/

namespace HelloMVCWorld.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return Content("Hello, MVC World!");
        }
    }
}