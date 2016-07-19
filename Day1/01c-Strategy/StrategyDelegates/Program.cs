using System;
using System.Collections.Generic;

namespace StrategyDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var evens = Where(numbers, n => n%2 == 0);

            foreach (var n in evens)
            {
                Console.WriteLine(n);
            }
        }

        static IEnumerable<TItem> Where<TItem>(IEnumerable<TItem> items,
            Func<TItem, bool> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
