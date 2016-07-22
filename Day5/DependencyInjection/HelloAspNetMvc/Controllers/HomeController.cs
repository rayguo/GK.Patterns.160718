using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using HelloAspNetMvc.Data.EF;
using HelloAspNetMvc.Entities;
using HelloAspNetMvc.Patterns;

namespace HelloAspNetMvc.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IProductsRepository _productsRepository
        //    = new ProductsRepository();

        private readonly IUnitOfWork _unitOfWork;
        //= new ProductsDbUnitOfWork();

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Home
        public async Task<ActionResult> Index()
        {
            var model = await _unitOfWork.ProductsRepository.GetProducts();
            return View(model);

            //var result = new ContentResult();
            //result.Content = "<h1>Hello ASP.NET MVC!</h1>";
            //return result;

            //var model = new List<Product>
            //{
            //    new Product {ProductId = 1, ProductName = "Chai", UnitPrice = 10M},
            //    new Product {ProductId = 2, ProductName = "Ikura", UnitPrice = 20M},
            //    new Product {ProductId = 3, ProductName = "Pavlova", UnitPrice = 30M},
            //};

            //using (var context = new ProductsDb())
            //{
            //    List<Product> model = context.Products
            //        .OrderBy(p => p.ProductName)
            //        .ToList();
            //    return View(model);
            //}
        }

        public async Task<ActionResult> Edit(int id)
        {
            var model = await _unitOfWork.ProductsRepository.GetProduct(id);
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(
            [Bind(Include = "ProductId,ProductName,UnitPrice")] Product product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductsRepository.UpdateProduct(product);
                await _unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        protected override void Dispose(bool disposing)
        {
            _unitOfWork.Dispose();
            base.Dispose(disposing);
        }
    }
}