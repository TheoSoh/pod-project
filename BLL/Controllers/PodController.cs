using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using DAL.Repository;
using System.Runtime.Serialization.Json;

namespace BLL.Controllers
{
    public class PodController
    {
        Serializer<Pod> serializer;

        public PodController()
        {
            serializer = new Serializer<Pod>();
        }
        public void CreatePod(string name, string url)
        {
            Pod newPod;
            newPod = new Pod(name,url);
            List<Pod> podList = new List<Pod>();
            podList.Add(newPod);
            serializer.Serialize(podList);
        }
     }   
}
