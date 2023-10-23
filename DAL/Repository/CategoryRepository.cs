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

    }
}
