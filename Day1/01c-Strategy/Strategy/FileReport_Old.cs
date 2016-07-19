using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class FileReport_Old
    {
        private string _directory;

        public FileReport_Old(string directory)
        {
            _directory = directory;
        }

        public void ProduceReport()
        {
            // Header
            Console.WriteLine($"Report of Directory {_directory}");

            // Columns
            Console.WriteLine("Filename,Size,Last Modified");

            // Rows
            foreach (var file in new DirectoryInfo(_directory).GetFiles())
            {
                Console.WriteLine($"{file.Name}, {file.Length}, {file.LastWriteTime}");
            }

            // Footer
            Console.WriteLine($"Report ran {DateTime.Now} by {WindowsIdentity.GetCurrent().Name}");
        }
    }
}
