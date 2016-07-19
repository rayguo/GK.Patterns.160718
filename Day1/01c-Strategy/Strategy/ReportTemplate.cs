using System;
using System.Security.Principal;

namespace Template
{
    abstract class ReportTemplate
    {
        public void ProduceReport(IReportOutputStrategy strategy)
        {
            // Header
            strategy.PrintTitle(GetTitle());

            // Columns
            strategy.StartTable(GetColumnNames());

            // Rows
            foreach (object[] row in GetRows())
            {
                strategy.PrintRow(row);
            }

            // Footer
            strategy.PrintFooter($"Report ran {DateTime.Now} by {WindowsIdentity.GetCurrent().Name}");
        }

        public abstract string GetTitle();
        public abstract string[] GetColumnNames();
        public abstract object[][] GetRows();
    }
}
