using System;
using System.Threading;

namespace ObserverWithDelegates
{
    class Dilbert
    {
        public event Action OnWorkStarted;

        public event Action<int> OnWorkProgressing;

        public event Action OnWorkCompleted;

        public void Work(int amount)
        {
            OnWorkStarted?.Invoke();

            for (int i = 1; i <= amount; i++)
            {
                OnWorkProgressing?.Invoke(i);

                Console.WriteLine($"Working on {i}");
                Thread.Sleep(500);
            }

            OnWorkCompleted?.Invoke();
        }

    }
}
