using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var pdfPrototype = new PdfDocument();

            var pdf1 = pdfPrototype.New();
            var pdf2 = pdfPrototype.New();
        }
    }
}
