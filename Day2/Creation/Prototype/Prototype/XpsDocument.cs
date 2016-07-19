using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class XpsDocument : Document, IDocumentPrototype
    {
        public string Style { get; set; }
        public Document New()
        {
            return new XpsDocument {Style = "Fancy"};
        }
    }
}
