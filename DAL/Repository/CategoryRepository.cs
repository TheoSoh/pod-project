using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repository
{
    public class CategoryRepository : ICategoryRepository<Pod>
    {
        List<Category> categoryList;
        Serializer<Category> serializer;
        
        public CategoryRepository()
        {
            categoryList = new List<Category>();
            serializer = new Serializer<Category>(nameof(categoryList));
        }

        public void Delete(string category)
        {

            ReaderWriterTxt.DeleteCategoryFromFile(category);
        }

        public void DeleteCategoryXml (string category)
        {
            RssReader.DeleteCategoryXml(category);
        }

        public void Update(string categoryName,string newCategoryName)
        {
            ReaderWriterTxt.Update(categoryName,newCategoryName);
        }

        public List<string> FetchAllCategories()
        {
            return ReaderWriterTxt.txtReader();
        }

        public void CreateDefaultCategories()
        {
            ReaderWriterTxt.txtWriter();
        }

        public void Update(string categoryName,string newCategoryName, string podTitle)
        {
            RssReader.Update(newCategoryName,newCategoryName,podTitle);
        }

        public void UpdateNameXml(string currentName,string newName,string podTitle)
        {
            RssReader.UpdateNameXml(currentName,newName,podTitle);
        }

        public void AddNewCategories(string newCategory)
        {
            ReaderWriterTxt.txtWriterNew(newCategory);
        }

        public void UpdateInXml(string categoryName, string newCategoryName)
        {
            RssReader.UpdateXml(categoryName, newCategoryName);
        }

       
    }

}
