using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverWithDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dilbert = new Dilbert();

            var boss = new PointyHeadBoss();

            var coworker = new Coworker();

            dilbert.OnWorkCompleted += coworker.WorkCompleted;

            dilbert.OnWorkStarted += boss.WorkStarted;
            dilbert.OnWorkProgressing += boss.WorkProgressed;
            dilbert.OnWorkCompleted += boss.WorkCompleted;

            dilbert.Work(6);
        }
    }
}
