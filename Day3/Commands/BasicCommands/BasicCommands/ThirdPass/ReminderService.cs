using System;
using System.Threading;

namespace BasicCommands.ThirdPass
{
    public class ReminderService
    {
        public void AddReminder(DateTime alarmTime, Command reminderCommand)
        {
            TimeSpan delta = alarmTime - DateTime.Now;

            var timer = new Timer(o =>
            {
                //Console.WriteLine($"Your {alarmTime} Alarm!");
                //strategy.ReminderCall($"Your {alarmTime} Alarm!");
                reminderCommand.Execute();

            }, null, delta, new TimeSpan(-1));
        }
    }
}
