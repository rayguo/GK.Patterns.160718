namespace CachingProxy
{
    public class StockServiceProxy : IStockService
    {
        StockCache _cache = new StockCache();

        public Stock GetStock(string symbol)
        {
            if (_cache.Stocks.ContainsKey(symbol))
            {
                return _cache.Stocks[symbol];
            }

            // Get from real service
            var service = new RealStockService();
            var stock = service.GetStock(symbol);

            // Put it in the cache
            _cache.Stocks.Add(symbol, stock);
            return stock;
        }
    }
}
