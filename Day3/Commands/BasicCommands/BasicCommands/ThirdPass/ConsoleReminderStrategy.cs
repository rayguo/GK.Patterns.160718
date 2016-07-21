using System;

namespace BasicCommands.ThirdPass
{
    public class ConsoleReminderStrategy : IReminderStrategy
    {
        public void ReminderCall(string text)
        {
            Console.WriteLine(text);
        }
    }
}
