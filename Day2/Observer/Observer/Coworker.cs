using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    class Coworker : IDisposable//IWorkObserver
    {
        private bool _disposed;
        private readonly Worker _worker;

        public Coworker(Worker worker)
        {
            _worker = worker;
            _worker.WorkCompleted += WorkCompleted;
        }

        //public void WorkStarted()
        //{
        //}

        //public void WorkProgressed(int item)
        //{
        //}

        public void WorkCompleted()
        {
            //Thread.Sleep(Timeout.Infinite);
            Console.WriteLine("Coworker: work completed");
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _worker.WorkCompleted -= WorkCompleted;
                _disposed = true;
            }
        }
    }
}
