using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace Prototype
{
    class PdfDocument : Document, IDocumentPrototype
    {
        // This might be expensive the first time
        public string Format { get; set; }

        public PdfDocument()
        {
            Format = "Plain";
        }
        public Document New()
        {
            //return new PdfDocument {Format = "Plain"};
            var doc = Clone(this);
            return doc;
        }

        private T Clone<T>(T item)
        {
            using (var stream = new MemoryStream())
            {
                var ser = new JsonSerializer();
                var writer = new BsonWriter(stream);
                ser.Serialize(writer, item);
                stream.Position = 0;

                var reader = new BsonReader(stream);
                var copy = ser.Deserialize<T>(reader);
                return copy;
            }
        }
    }
}
