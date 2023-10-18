using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {

        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }

        public string CategoryName { get; set; }

    }
}
