using System;
using System.Security.Principal;

namespace Template
{
    abstract class ReportTemplate
    {
        public void ProduceReport()
        {
            // Header
            Console.WriteLine(GetTitle());

            // Columns
            Console.WriteLine(string.Join(",", GetColumnNames()));

            // Rows
            foreach (object[] row in GetRows())
            {
                Console.WriteLine(string.Join(",", row));
            }

            // Footer
            Console.WriteLine($"Report ran {DateTime.Now} by {WindowsIdentity.GetCurrent().Name}");
        }

        public abstract string GetTitle();
        public abstract string[] GetColumnNames();
        public abstract object[][] GetRows();
    }
}
