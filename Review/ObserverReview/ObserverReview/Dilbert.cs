using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverReview
{
    class Dilbert
    {
        private List<IObserver> _observers = new List<IObserver>();
        public void Work(int amount)
        {
            foreach (var observer in _observers)
                observer.WorkStarted();

            for (int i = 1; i <= amount; i++)
            {
                foreach (var observer in _observers)
                {
                    observer.WorkProgressed(i);
                }
                Console.WriteLine($"Working on {i}");
                Thread.Sleep(500);
            }

            _observers.ForEach(o => o.WorkCompleted());

        }

        public void Subscribe(IObserver person)
        {
            _observers.Add(person);
        }

        public void Unsubscribe(IObserver person)
        {
            _observers.Remove(person);
        }
    }
}
