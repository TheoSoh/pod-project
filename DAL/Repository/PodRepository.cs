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
        List<Pod> pods;
        Serializer<Pod> serializer;
        public PodRepository()
        {
            pods = new List<Pod>();
            serializer = new Serializer<Pod>();
        }
        public List<Pod> GetAll()
        {
            throw new Exception();
        }

        public void Create (Pod item)
        {
            throw new Exception (); 
        }

        
    }
}
