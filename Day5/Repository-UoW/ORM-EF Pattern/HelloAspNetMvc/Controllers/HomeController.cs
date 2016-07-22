using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloAspNetMvc.Data.EF;
using HelloAspNetMvc.Entities;

namespace HelloAspNetMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var result = new ContentResult();
            //result.Content = "<h1>Hello ASP.NET MVC!</h1>";
            //return result;

            //var model = new List<Product>
            //{
            //    new Product {ProductId = 1, ProductName = "Chai", UnitPrice = 10M},
            //    new Product {ProductId = 2, ProductName = "Ikura", UnitPrice = 20M},
            //    new Product {ProductId = 3, ProductName = "Pavlova", UnitPrice = 30M},
            //};

            using (var context = new ProductsDb())
            {
                List<Product> model = context.Products
                    .OrderBy(p => p.ProductName)
                    .ToList();
                return View(model);
            }
        }

        public ActionResult Edit(int id)
        {
            using (var context = new ProductsDb())
            {
                var model = context.Products
                    .SingleOrDefault(p => p.ProductId == id);
                return View(model); 
            }
        }
    }
}