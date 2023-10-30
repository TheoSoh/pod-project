using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Linq;
using System.Xml;

namespace DAL
{
    internal static class ReaderWriterTxt
    {
        public static void txtWriter()
        {
            string[] lines = { "","Komedi", "Historia", "Crime", "Sport" };

            try
            {

                using (FileStream fileStream = new FileStream("Category.txt", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        foreach (string line in lines)
                            writer.WriteLine(line);
                    }
                }
            } catch (IOException e) 
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void txtWriterNew(string newCategory)
        {

            try
            {
                using (FileStream fileStream = new FileStream("Category.txt", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        writer.WriteLine(newCategory);

                    }
                }
            }catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static List<string> txtReader()
        {
            List<string> result = new List<string>();
            try
            {
              using (FileStream fileStream = new FileStream("Category.txt", FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            line = reader.ReadLine();
                            string category = new string(line);
                            result.Add(category);
                        }
                       
                    }
                
              }

            } catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }


        public static void DeleteCategoryFromFile (string category)
        {
            try
            {
                var categories = File.ReadAllLines("Category.txt").ToList();
                if (categories.Contains(category))
                {
                    categories.Remove(category);
                    File.WriteAllLines("Category.txt", categories);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Update (string categoryName, string newCategoryName)
        {
            try
            {
                var categories = File.ReadAllText("Category.txt");


                categories = categories.Replace(categoryName, newCategoryName);

                File.WriteAllText("Category.txt", categories);

            }catch(Exception e)
            {
                throw new Exception("", e);
            }

        }

       

      
    }
}

    

