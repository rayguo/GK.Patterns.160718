using System.Collections.Generic;

namespace CachingProxy
{
    public class StockCache
    {
        public StockCache()
        {
            Stocks = new Dictionary<string, Stock>();
        }

        public Dictionary<string, Stock> Stocks { get; private set; }

    }
}
