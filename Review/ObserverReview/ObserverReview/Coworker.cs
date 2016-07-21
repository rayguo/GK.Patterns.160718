using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverReview
{
    class Coworker : IObserver
    {
        public void WorkStarted()
        {
        }

        public void WorkProgressed(int amount)
        {
        }

        public void WorkCompleted()
        {
            Console.WriteLine( "coworker: Work completed" );
        }
    }
}
