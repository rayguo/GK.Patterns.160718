using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //var service = new RealStockService();
            //UseRealStockService(service);

            IStockService service = new StockServiceProxy();
            UseProxyStockService(service);
        }

        private static void UseProxyStockService(IStockService service)
        {
            while (true)
            {
                Console.WriteLine("\nStock Symbol:");
                string symbol = Console.ReadLine();

                var sw = Stopwatch.StartNew();
                var stock = service.GetStock(symbol);
                sw.Stop();

                Console.WriteLine($"Stock: {stock} {sw.ElapsedMilliseconds}");
            }
        }

        private static void UseRealStockService(RealStockService service)
        {
            while (true)
            {
                Console.WriteLine("\nStock Symbol:");
                string symbol = Console.ReadLine();

                var sw = Stopwatch.StartNew();
                var stock = service.GetStock(symbol);
                sw.Stop();

                Console.WriteLine($"Stock: {stock} {sw.ElapsedMilliseconds}");
            }
        }
    }
}
