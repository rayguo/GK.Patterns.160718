using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Boss : IDisposable //IWorkObserver
    {
        private bool _disposed;
        private readonly Worker _worker;

        public Boss(Worker worker)
        {
            _worker = worker;
            _worker.WorkStarted += WorkStarted;
            _worker.WorkProgressed += WorkProgressed;
            _worker.WorkCompleted += WorkCompleted;
        }

        public void WorkStarted()
        {
            Console.WriteLine("Boss: Work Started");
        }

        public void WorkProgressed(int item)
        {
            Console.WriteLine($"Boss: Work progressing on {item}");
        }

        public void WorkCompleted()
        {
            Console.WriteLine("Boss: Work completed");
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _worker.WorkStarted -= WorkStarted;
                _worker.WorkProgressed -= WorkProgressed;
                _worker.WorkCompleted -= WorkCompleted;
                _disposed = true;
            }
        }
    }
}
