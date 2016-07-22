using System.Collections.Generic;
using System.Threading.Tasks;
using HelloAspNetMvc.Entities;

namespace HelloAspNetMvc.Patterns
{
    public interface IProductsRepository
    {
        Task<IList<Product>> GetProducts();

        Task<Product> GetProduct(int id);

        Product UpdateProduct(Product product);

        // TODO: Add methods for insert and update
    }
}
