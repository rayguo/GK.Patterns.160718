using System.Windows.Forms;

namespace BasicCommands.ThirdPass
{
    public class MessageBoxReminderStrategy : IReminderStrategy
    {
        public void ReminderCall(string text)
        {
            MessageBox.Show(text, "Alarm");
        }
    }
}
