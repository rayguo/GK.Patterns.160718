using System;
using System.Threading.Tasks;

namespace HelloAspNetMvc.Patterns
{
    public interface IUnitOfWork : IDisposable
    {
        IProductsRepository ProductsRepository { get; set; }

        Task<int> SaveChanges();
    }
}
