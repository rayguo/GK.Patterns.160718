## Unit Of Work Pattern Exercise

1. Add a public IUnitOfWork interface to the
   .Patterns project.
   - Add a SaveChanges method

   ```csharp
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
    ```

2. Add a public ProductsDbUnitOfWork class
   to the .Data.EF project
   - Implement IUnitOfWorj
   - Add a ProductsDb field
     + Init from ctor
   - Add IProductsRepository field 
     and init a new ProductsRepo

3. Refactor ProductsRepo class
  - Add ctor accepting ProductsDb
  - Init a private _context
  - Remove using blocks
  - Use _context

   ```
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

```





  
