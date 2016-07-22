## Repository Pattern Exercise

1. Add a Class Library project to the solution
   - Name it the same as the web app + .Patterns
   - Remove Class1.cs
   - Reference the .Entities project
   - Add a public interface called IProductsRepository

   ```csharp
    public interface IProductsRepository
    {
        IList<Product> GetProducts();

        Product GetProduct(int id);

        Product UpdateProduct(Product product);

        // TODO: Add methods for insert and update
    }
    ```

2. Add a ProductRepository class to the Data.EF project
   - Reference the .Patterns project from the Data.EF project
   - Refactor ProductRepository to implement IProductsRepository






















  
