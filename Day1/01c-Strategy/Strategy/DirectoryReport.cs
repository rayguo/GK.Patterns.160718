using System;
using System.IO;
using System.Linq;
using System.Security.Principal;

namespace Template
{
    class DirectoryReport : ReportTemplate
    {
        private readonly string _directory;

        public DirectoryReport(string directory)
        {
            _directory = directory;
        }

        public override string GetTitle()
        {
            return $"Report of Directory {_directory}";
        }

        public override string[] GetColumnNames()
        {
            return new[] { "Filename", "Created", "Last Modified" };
        }

        public override object[][] GetRows()
        {
            var files = from r in new DirectoryInfo(_directory).GetDirectories()
                select new object[] {r.Name, r.CreationTime, r.LastWriteTime};
            return files.ToArray();
        }
    }
}
