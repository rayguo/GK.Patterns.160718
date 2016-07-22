## ORM Pattern Exercise

1. Add a Class Library project to the solution
   - Name it the same as the web app + .Data.EF
   - Remove Class1.cs
   - Add EntityFramework Nuget package
     + View, Other Windows, Package Manager Console
     + install-package EntityFramework

2. Add a new item to the Data.EF project
   - Under Data category, ADO.NET Entity Data Model
   - Name it ProductsDb
   - Choose Empty Code First Model

3. Add another Class Library to the solution
   - Name it the same as the web app + .Entities
   - Add a new public Product class
     + int ProductId
     + string ProductName
     + decimal UnitPrice

4. Add a reference in the Data.EF project
   to the .Entities project
  - Uncomment line of code for the property and change to:

    ```csharp
    public virtual DbSet<Product> Products { get; set; }
    ```

5. Grab the connection string XML fragment from here:
  - https://gist.github.com/tonysneed/
  - tonysneed / NorthwindSlim.Connections.xml

  ```xml
	<connectionStrings>
    <!--<add name="ProductsDb" connectionString="Data Source=.\sqlexpress;Initial Catalog=ProductsDb;Integrated Security=True;MultipleActiveResultSets=True" providerName="System.Data.SqlClient" />-->
    <add name="ProductsDb" connectionString="Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProductsDb.mdf;Integrated Security=True" providerName="System.Data.SqlClient" />
  </connectionStrings>
  ```
  - Replace NorthwindSlim and NorthwindSlimContext with ProductsDb
  - Paste this into the web.config file in the web project
  - This will cause EF to create the database file in the App_Data folder of the web project

6. Open the Home controller in the web project
   - Add two reference to the web project:
     + .Entities
     + .Data.EF
   - Add the EntityFramework NuGet package to the web project
   - Delete the all classes from the Models folder of the web project
   - Refactor the Index method to use EF to get the data

   ```csharp
    using (var context = new ProductsDb())
    {
        List<Product> model = context.Products
            .OrderBy(p => p.ProductName)
            .ToList();
        return View(model);
    }
    ```

7. Refactor the Edit method as well.

  ```csharp
    public ActionResult Edit(int id)
    {
        using (var context = new ProductsDb())
        {
            var model = context.Products
                .SingleOrDefault(p => p.ProductId == id);
            return View(model); 
        }
    }
    ```

8. Delete and re-add the Index and Edit views in the Views/Home folder.
  - Right-click, add Controller
  - Index template = List, Edit template = Edit
  - Choose Product class as the model
  - Leave Data context class blank
  - Check the layout option

9. Build and run the web app
   - You may need to remove from HomeController: using 
   - Set a breakpoint in the Index method













  
