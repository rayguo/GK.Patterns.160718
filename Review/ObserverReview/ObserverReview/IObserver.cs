using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverReview
{
    interface IObserver
    {
        void WorkStarted();
        void WorkProgressed(int amount);
        void WorkCompleted();
    }
}
