using System;

namespace ObserverWithDelegates
{
    class PointyHeadBoss
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
