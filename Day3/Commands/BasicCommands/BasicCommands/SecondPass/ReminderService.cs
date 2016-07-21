using System;
using System.Threading;

namespace BasicCommands.SecondPass
{
    public class ReminderService
    {
        public void AddReminder(DateTime alarmTime, IReminderStrategy strategy)
        {
            TimeSpan delta = alarmTime - DateTime.Now;

            var timer = new Timer(o =>
            {
                //Console.WriteLine($"Your {alarmTime} Alarm!");
                strategy.ReminderCall($"Your {alarmTime} Alarm!");

            }, null, delta, new TimeSpan(-1));
        }
    }
}
