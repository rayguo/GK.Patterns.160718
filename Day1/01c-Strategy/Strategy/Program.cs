using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = @"c:\windows";
            var report = new DirectoryReport(directory);

            //IReportOutputStrategy strategy = new ConsoleOutputStrategy();
            IReportOutputStrategy strategy = new FileOutputStrategy
                (@"..\..\report.txt");
            report.ProduceReport(strategy);
        }
    }
}
