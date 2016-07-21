namespace CachingProxy
{
    public interface IStockService
    {
        Stock GetStock(string symbol);
    }
}