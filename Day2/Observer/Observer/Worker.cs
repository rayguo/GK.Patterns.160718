using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    class Worker
    {
        public event Action WorkStarted;
        public event Action<int> WorkProgressed;
        public event Action WorkCompleted;

        //private readonly IList<IWorkObserver> _observers
        //    = new List<IWorkObserver>();

        //public void AddObservers(params IWorkObserver[] observers)
        //{
        //    foreach (var observer in observers)
        //    {
        //        _observers.Add(observer);
        //    }
        //}

        //public void RemoveObserver(params IWorkObserver[] observers)
        //{
        //    foreach (var observer in observers)
        //    {
        //        _observers.Remove(observer);
        //    }
        //}

        public void Work(int amount)
        {
            //WorkStarted?.BeginInvoke(ar => ar.AsyncWaitHandle.Dispose(), null);
            foreach (Action target in WorkStarted?.GetInvocationList())
            {
                target.BeginInvoke(ar => ar.AsyncWaitHandle.Dispose(), null);
            }

            //foreach (var observer in _observers)
            //{
            //    observer.WorkStarted();
            //}

            for (int i = 1; i <= amount; i++)
            {
                // Simulate work by sleeping
                Console.WriteLine($"Working on {i}");
                Thread.Sleep(400);

                foreach (Action<int> target in WorkProgressed?.GetInvocationList())
                {
                    target.BeginInvoke(i, ar => ar.AsyncWaitHandle.Dispose(), null);
                }
                //WorkProgressed?.Invoke(i);
                //foreach (var observer in _observers)
                //{
                //    observer.WorkProgressed(i);
                //}
            }

            foreach (Action target in WorkCompleted?.GetInvocationList())
            {
                target.BeginInvoke(ar => ar.AsyncWaitHandle.Dispose(), null);
            }
            //WorkCompleted?.Invoke();
            //foreach (var observer in _observers)
            //{
            //    observer.WorkCompleted();
            //}
        }
    }
}
