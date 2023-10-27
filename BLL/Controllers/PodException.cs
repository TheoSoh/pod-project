using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Controllers
{
    public class PodException : Exception
    {

        public PodException(string message) : base(message)
        {
        }
    }
}
