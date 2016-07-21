using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverReview
{
    class Program
    {
        static void Main(string[] args)
        {
            var dilbert = new Dilbert();

            var boss = new PointyHeadBoss();

            var coworker = new Coworker();

            dilbert.Subscribe(coworker);

            dilbert.Subscribe(boss);

            dilbert.Work(6);
        }
    }
}
