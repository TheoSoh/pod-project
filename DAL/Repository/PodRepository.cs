using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repository
{
    public class PodRepository: IRepository<Pod>
    {
        

        public PodRepository()
        {
            
        }
        public List<Pod> GetAll()
        {
            throw new Exception();
        }
    }
}
