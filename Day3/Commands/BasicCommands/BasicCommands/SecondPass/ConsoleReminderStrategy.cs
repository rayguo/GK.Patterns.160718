using System;

namespace BasicCommands.SecondPass
{
    public class ConsoleReminderStrategy : IReminderStrategy
    {
        public void ReminderCall(string text)
        {
            Console.WriteLine(text);
        }
    }
}
