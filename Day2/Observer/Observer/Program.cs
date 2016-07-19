using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();

            using (var boss = new Boss(worker))
            using (var coworker = new Coworker(worker))
            {
                Console.WriteLine("Amount to work:");
                int amount = int.Parse(Console.ReadLine());

                worker.Work(amount);
            }

            //worker.AddObservers(boss, coworker);
        }
    }
}
