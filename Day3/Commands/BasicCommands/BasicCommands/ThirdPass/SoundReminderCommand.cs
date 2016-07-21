using System.Media;

namespace BasicCommands.ThirdPass
{
    public class SoundReminderCommand : Command
    {
        private IReminderStrategy _strategy;
        private string _message;
        private string _wavFile;

        public SoundReminderCommand(IReminderStrategy strategy, 
            string message, string wavFile)
        {
            _strategy = strategy;
            _message = message;
            _wavFile = wavFile;
        }

        public override void Execute()
        {
            var player = new SoundPlayer(_wavFile);
            player.Play();
            _strategy.ReminderCall(_message);
        }
    }
}
