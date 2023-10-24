using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        List<Category> categoryList;
        Serializer<Category> serializer;
        
        public CategoryRepository()
        {
            categoryList = new List<Category>();
            serializer = new Serializer<Category>(nameof(categoryList));
        }

        public List<Category> GetAll()
        {
            throw new Exception();
        }

        public void Update()
        {
            throw new Exception();
        }

        public void Delete(string category)
        {

            ReaderWriterTxt.DeleteCategoryFromFile(category);
        }

        
        public void Add(Category item)
        {
            throw new NotImplementedException();
        }

        public void Create(Category item)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public List<string> FetchAllCategories()
        {
            return ReaderWriterTxt.txtReader();
        }

        public void CreateDefaultCategories()
        {
            ReaderWriterTxt.txtWriter();
        }

        public void AddNewCategories(string newCategory)
        {
            ReaderWriterTxt.txtWriterNew(newCategory);
        }
    }
}
