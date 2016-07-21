using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12};

            Console.WriteLine("Divisor:");
            int divisor = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var result1 = Divide(ints, divisor);

            var result2 = result1.Where(i => i%(divisor*2) == 0);

            var result3 = result2.Reverse();

            var cache = result1.ToList();

            foreach (var i in cache)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            foreach (var i in cache)
            {
                Console.WriteLine(i);
            }
        }

        static IEnumerable<int> Divide(IEnumerable<int> ints, int divisor)
        {
            foreach (var i in ints)
            {
                if (i % divisor == 0)
                {
                    Console.WriteLine($"int: {i}");
                    yield return i;
                }
            }
        }
    }
}
