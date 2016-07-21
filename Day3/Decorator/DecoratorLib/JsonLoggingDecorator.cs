using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DecoratorLib
{
    public class JsonLoggingDecorator<T> : ListDecorator<T>
    {
        public JsonLoggingDecorator(IList<T> innerList)
            : base(innerList)
        {
            
        }

        public override void Insert(int index, T item)
        {
            LogJson(item, "Add");
            base.Insert(index, item);
        }

        public override void RemoveAt(int index)
        {
            T item = _innerList[index];
            LogJson(item, "Remove");
            base.RemoveAt(index);
        }

        private void LogJson(T item, string operation)
        {
            string logFile = string.Format(@"..\..\Logs\{0}.{1}.log.json",
                typeof(T).Name, operation.ToLower());
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter(logFile, true))
            using (var writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, item);
                sw.WriteLine();
            }
        }
    }
}
