using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using Models;
using DAL;




namespace BLL.Controllers
{
    public class ValidationController 
    {

        IPodRepository<Pod> podRepo;
        CategoryRepository categoryRepo;


        public ValidationController()
        {
            podRepo = new PodRepository();
            categoryRepo = new CategoryRepository();
        }


        public bool CheckIfStringIsEmpty(string text)
        {
            if ((text == null) || (text == ""))
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }

        public bool CheckIfCategoryExist(string categoryName)
        {
            var selectCategory = from aCategory in categoryRepo.FetchAllCategories()
                                 where aCategory.Equals(categoryName)
                                 select aCategory;
        return selectCategory.Any();

        }


        public bool CheckIfNameExist (string name) 
        { 
            var selectName = from aPod in podRepo.GetAll()
                             where aPod.Name.Equals(name)
                             select aPod.Name;
            return selectName.Any();
        }

        public bool CheckIfUrlExist(string url)
        {
            var selectUrl = from aPod in podRepo.GetAll()
                            where aPod.Url.Equals(url)
                            select aPod.Url;
            return selectUrl.Any();
        }


    }
}
