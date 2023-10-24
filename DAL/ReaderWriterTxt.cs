using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Linq;

namespace DAL
{
    internal static class ReaderWriterTxt
    {
        public static void txtWriter()
        {
            string[] lines = { "","Komedi", "Historia", "Crime", "Sport" };

            using (FileStream fileStream = new FileStream("Category.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    foreach (string line in lines)
                        writer.WriteLine(line);
                }
            }

        }

        public static void txtWriterNew(string newCategory)
        {
            using (FileStream fileStream = new FileStream("Category.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine(newCategory);
                  
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


        public static void DeleteCategoryFromFile (string category)
        {
            var categories = File.ReadAllLines("Category.txt").ToList();
            if(categories.Contains(category))
            {
                categories.Remove(category);
                File.WriteAllLines("Category.txt", categories);
            }
        }

      
    }
}

    

