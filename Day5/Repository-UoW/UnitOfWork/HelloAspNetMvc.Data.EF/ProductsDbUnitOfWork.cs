using System;
using System.Threading.Tasks;
using HelloAspNetMvc.Patterns;

namespace HelloAspNetMvc.Data.EF
{
    public class ProductsDbUnitOfWork : IUnitOfWork
    {
        private bool _disposed;
        private readonly ProductsDb _context = new ProductsDb();

        public IProductsRepository ProductsRepository { get; set; }

        public ProductsDbUnitOfWork()
        {
            ProductsRepository = new ProductsRepository(_context);
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                var disposable = _context as IDisposable;
                disposable?.Dispose();

                _disposed = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ProductsDbUnitOfWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
    }
}
