using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UpdateCore.Configs.Components.Files
{
    internal class ValueFile
    {
        private readonly string _filePath;
        public ValueFile(string filePath)
        {
            _filePath = filePath;
        }
        public void Save(ValueData[] values)
        {
            XmlSerializer serializer = new (typeof(ValueData[]));
            StreamWriter writer = new (_filePath, false, Encoding.UTF8);
            serializer.Serialize(writer, values);
            writer.Close();
        }
        public ValueData[] Load()
        {
            if (File.Exists(_filePath) is false)
            {
                return Array.Empty<ValueData>();
            }
            XmlSerializer serializer = new(typeof(ValueData[]));
            StreamReader reader = new(_filePath, Encoding.UTF8);
            ValueData[] values = (ValueData[]?)serializer.Deserialize(reader) ?? Array.Empty<ValueData>();
            reader.Close();

            return values;
        }
    }
}
