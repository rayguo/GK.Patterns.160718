using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using HelloAspNetMvc.Entities;
using HelloAspNetMvc.Patterns;

namespace HelloAspNetMvc.Data.EF
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductsDb _context;

        public ProductsRepository(ProductsDb context)
        {
            _context = context;
        }

        public async Task<IList<Product>> GetProducts()
        {
            List<Product> model = await _context.Products
                .OrderBy(p => p.ProductName)
                .ToListAsync();
            return model;
        }

        public async Task<Product> GetProduct(int id)
        {
            var model = await _context.Products
                .SingleOrDefaultAsync(p => p.ProductId == id);
            return model;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
