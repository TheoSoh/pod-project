using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    internal static class ReaderWriterTxt
    {
        public static void txtWriter()
        {
            string[] lines = { "Komedi", "Historia", "Sport" };

            using (FileStream fileStream = new FileStream("Category.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    foreach (string line in lines)
                        writer.WriteLine(line);
                }
            }

        }

        public static List<string> txtReader()
        {
            using (FileStream fileStream = new FileStream("Category.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    List<string> result = new List<string>();
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        line = reader.ReadLine();
                        string category = new string(line);
                        result.Add(category);
                    }
                    return result;
                }
            }
        }

    }
}

    

