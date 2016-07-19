using System;
using System.IO;
using System.Text;

namespace Template
{
    class FileOutputStrategy : IReportOutputStrategy, IDisposable
    {
        private bool _disposed;

        private readonly StreamWriter _writer;

        public FileOutputStrategy(string path)
        {
            _writer = new StreamWriter(path);
            //_writer = new StreamWriter(path, true,
            //    Encoding.Unicode, 10000);
        }

        public void PrintTitle(string title)
        {
            _writer.WriteLine(title);
        }

        public void StartTable(string[] columns)
        {
            _writer.WriteLine(string.Join(",", columns));
        }

        public void PrintRow(object[] row)
        {
            _writer.WriteLine(string.Join(",", row));
        }

        public void PrintFooter(string footer)
        {
            _writer.WriteLine(footer);
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _writer.Dispose();
                _disposed = true;
            }
        }
    }
}
