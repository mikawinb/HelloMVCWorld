using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Product overview");
        }

        public IActionResult List()
        {
            return Content("Product List");
        }

        public IActionResult Details(int id)
        {
            Models.Product product = new Models.Product();
            product.name = GetProduct(id);

            if (product != null)
                return View(product);
            return NotFound();
        }
        string GetProduct(int id)
        {
            return "Produkten";
        }
    }

    
}