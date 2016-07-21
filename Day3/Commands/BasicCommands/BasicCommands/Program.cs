using System;

namespace BasicCommands
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseFirstPass();
            //UseSecondPass();
            UseThirdPass();
        }

        private static void UseThirdPass()
        {
            ThirdPass.IReminderStrategy strategy;
            Console.WriteLine("Stategy: Console {C}, Message Box {any}");
            if (Console.ReadLine().ToUpper() == "C")
            {
                strategy = new ThirdPass.ConsoleReminderStrategy();
            }
            else
            {
                strategy = new ThirdPass.MessageBoxReminderStrategy();
            }

            var service = new ThirdPass.ReminderService();

            while (true)
            {
                Console.WriteLine("Remind in N seconds:");
                int seconds = int.Parse(Console.ReadLine());
                var alarmTime = DateTime.Now.AddSeconds(seconds);
                string message = $"Your {alarmTime} Alarm!";
                string wavFile = @"c:\windows\media\tada.wav";

                var command = new ThirdPass.SoundReminderCommand(strategy,
                    message, wavFile);

                service.AddReminder(alarmTime, command);
            }
        }

        private static void UseSecondPass()
        {
            SecondPass.IReminderStrategy strategy;
            Console.WriteLine("Stategy: Console {C}, Message Box {any}");
            if (Console.ReadLine().ToUpper() == "C")
            {
                strategy = new SecondPass.ConsoleReminderStrategy();
            }
            else
            {
                strategy = new SecondPass.MessageBoxReminderStrategy();
            }

            var service = new SecondPass.ReminderService();

            while (true)
            {
                Console.WriteLine("Remind in N seconds:");
                int seconds = int.Parse(Console.ReadLine());
                var alarmTime = DateTime.Now.AddSeconds(seconds);

                service.AddReminder(alarmTime, strategy);
            }
        }

        private static void UseFirstPass()
        {
            var service = new FirstPass.ReminderService();

            while (true)
            {
                Console.WriteLine("Remind in N seconds:");
                int seconds = int.Parse(Console.ReadLine());
                var alarmTime = DateTime.Now.AddSeconds(seconds);

                service.AddReminder(alarmTime);
            }
        }
    }
}
