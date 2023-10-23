using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAL
{
    internal class Serializer<T>
    {
        private string path;

        public Serializer(string path)
        {
            this.path = path + ".xml";
        }

        public void Serialize(List<T> list)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                using (FileStream xmlOut = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(xmlOut, list);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public List<T> Deserialize()
        {
            List<T> list = new List<T>();
            if (File.Exists(path))
            {
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                    using (FileStream xmlIn = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        list = (List<T>)xmlSerializer.Deserialize(xmlIn);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            return list;
        }

    }
}
