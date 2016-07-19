using System;
using System.IO;
using System.Linq;
using System.Security.Principal;

namespace Template
{
    class FileReport : ReportTemplate
    {
        private readonly string _directory;

        public FileReport(string directory)
        {
            _directory = directory;
        }

        public override string GetTitle()
        {
            return $"Report of Directory {_directory}";
        }

        public override string[] GetColumnNames()
        {
            return new[] { "Filename", "Size", "Last Modified" };
        }

        public override object[][] GetRows()
        {
            var files = from r in new DirectoryInfo(_directory).GetFiles()
                select new object[] {r.Name, r.Length, r.LastWriteTime};
            return files.ToArray();
        }
    }
}
