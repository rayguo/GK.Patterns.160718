using System;
using System.Threading;

namespace BasicCommands.FirstPass
{
    public class ReminderService
    {
        public void AddReminder(DateTime alarmTime)
        {
            TimeSpan delta = alarmTime - DateTime.Now;

            var timer = new Timer(o =>
            {
                Console.WriteLine($"Your {alarmTime} Alarm!");

            }, null, delta, new TimeSpan(-1));
        }
    }
}
