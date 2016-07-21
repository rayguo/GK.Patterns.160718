using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DecoratorLib
{
    public class XmlLoggingDecorator<T> : ListDecorator<T>
    {
        public XmlLoggingDecorator(IList<T> innerList) : base(innerList)
        {
        }

        public override void Insert(int index, T item)
        {
            LogXml(item, "Add");
            base.Insert(index, item);
        }

        public override void RemoveAt(int index)
        {
            T item = _innerList[index];
            LogXml(item, "Remove");
            base.RemoveAt(index);
        }

        private void LogXml(T item, string operation)
        {
            string logFile = string.Format(@"..\..\Logs\{0}.{1}.log.xml",
                typeof(T).Name, operation.ToLower());

            var settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true
            };

            var ns = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(typeof(T));

            using (var sw = new StreamWriter(logFile, true))
            using (var xmlWriter = XmlWriter.Create(sw, settings))
            {
                serializer.Serialize(xmlWriter, item, ns);
                sw.WriteLine();
            }
        }
    }
}
