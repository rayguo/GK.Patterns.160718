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
        public async Task<IList<Product>> GetProducts()
        {
            using (var context = new ProductsDb())
            {
                List<Product> model = await context.Products
                    .OrderBy(p => p.ProductName)
                    .ToListAsync();
                return model;
            }
        }

        public async Task<Product> GetProduct(int id)
        {
            using (var context = new ProductsDb())
            {
                var model = await context.Products
                    .SingleOrDefaultAsync(p => p.ProductId == id);
                return model;
            }
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            using (var context = new ProductsDb())
            {
                context.Entry(product).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return product;
            }
        }
    }
}
