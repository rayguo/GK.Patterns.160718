using System;

namespace Template
{
    class ConsoleOutputStrategy : IReportOutputStrategy
    {
        public void PrintTitle(string title)
        {
            Console.WriteLine(title);
        }

        public void StartTable(string[] columns)
        {
            Console.WriteLine(string.Join(",", columns));
        }

        public void PrintRow(object[] row)
        {
            Console.WriteLine(string.Join(",", row));
        }

        public void PrintFooter(string footer)
        {
            Console.WriteLine(footer);
        }
    }
}
