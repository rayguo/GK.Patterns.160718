using System;
using System.Threading;

namespace CachingProxy
{
    public class RealStockService : IStockService
    {
        public Stock GetStock(string symbol)
        {
            // Simulate network call
            Thread.Sleep(new Random().Next(3000));

            // Get a random price
            var price = new Random().Next(1000);
            var stock = new Stock
            {
                Symbol = symbol,
                Price = price
            };
            return stock;
        }
    }
}
