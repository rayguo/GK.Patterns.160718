using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IWorkObserver
    {
        void WorkStarted();
        void WorkProgressed(int item);
        void WorkCompleted();
    }
}
