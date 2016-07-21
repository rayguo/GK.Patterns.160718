using System.Windows.Forms;

namespace BasicCommands.SecondPass
{
    public class MessageBoxReminderStrategy : IReminderStrategy
    {
        public void ReminderCall(string text)
        {
            MessageBox.Show(text, "Alarm");
        }
    }
}
