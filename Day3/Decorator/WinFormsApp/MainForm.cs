using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DecoratorLib;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private BindingList<Jedi> _jediList;

        public MainForm()
        {
            InitializeComponent();

            // Create the binding list
            var jediList = new List<Jedi>();

            // Add json logging
            var jsonDecorator = new JsonLoggingDecorator<Jedi>
                (jediList);

            var xmlDecorator = new XmlLoggingDecorator<Jedi>
                (jsonDecorator);

            // Bind list to the data grid
            _jediList = new BindingList<Jedi>(xmlDecorator);
            jediBindingSource.DataSource = _jediList;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var jedi = new Jedi
            {
                Name = nameTextBox.Text,
                Rank = (Rank) Enum.Parse(typeof(Rank),
                    rankTextBox.Text),
                Years = int.Parse(yearsTextBox.Text)
            };
            _jediList.Add(jedi);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var jedi = (Jedi)jediBindingSource.Current;
            _jediList.Remove(jedi);
        }
    }
}
