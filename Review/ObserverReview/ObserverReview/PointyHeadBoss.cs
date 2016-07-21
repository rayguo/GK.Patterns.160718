using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverReview
{
    class PointyHeadBoss : IObserver
    {
        public void WorkStarted()
        {
            Console.WriteLine("Work Started");
        }

        public void WorkProgressed(int amount)
        {
            Console.WriteLine($"Work progressing {amount}");
        }

        public void WorkCompleted()
        {
            Console.WriteLine("Work completed");
        }
    }
}
