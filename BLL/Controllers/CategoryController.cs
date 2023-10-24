using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using DAL.Repository;

namespace BLL.Controllers
{
    public class CategoryController
    {
       CategoryRepository categoryRepository;


        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }

        public List<string> ReadAllCategorys()
        {

            List<string> listCategory = categoryRepository.FetchAllCategories();
            return listCategory;
        }

        public void AddNewCategory()
        {
            categoryRepository.CreateDefaultCategories();
        }

        public void addNewCategoryToTxt(string categoryName)
        {
            categoryRepository.AddNewCategories(categoryName);
        }

        public void removeCategory(string categoryName)
        {
            categoryRepository.Delete(categoryName);
        }

    }
}







