using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BLL.Controllers
{
    public static class ValidationController
    {


        public static bool CheckIfStringIsEmpty(string text)
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
    }
}
