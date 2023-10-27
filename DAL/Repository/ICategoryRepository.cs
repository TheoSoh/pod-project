using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface ICategoryRepository<T> where T : class
    {
        public void Delete(string category);
        public void DeleteCategoryXml(string category);
        public void Update(string categoryName, string newCategoryName);
        public List<string> FetchAllCategories();
        public void CreateDefaultCategories();
        public void Update(string categoryName, string newCategoryName, string podTitle);
        public void UpdateNameXml(string currentName, string newName, string podTitle);
        public void AddNewCategories(string newCategory);
        public void UpdateInXml(string categoryName, string newCategoryName);
    }
}
