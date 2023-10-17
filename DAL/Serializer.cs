using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Models;
using System.IO;

namespace DAL
{
    internal class Serializer<T>
    {


        public void Serialize(List<T> list)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            try
            {
                using (FileStream xmlOut = new FileStream("", FileMode.Append, FileAccess.Write))
                {
                    xmlSerializer.Serialize(xmlOut, list);
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<T> Deserialize()
        {
            List<T> list = new List<T>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            try
            {
                using (FileStream xmlIn = new FileStream("", FileMode.Append, FileAccess.Read))
                {
                    list = (List<T>)xmlSerializer.Deserialize(xmlIn);
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            } 
            return list;
        }


    }
}
