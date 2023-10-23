using DAL;
using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PodController
    {
        IPodRepository<Pod> podRepo;

        public PodController()
        {
            podRepo = new PodRepository();
        }
        public void CreatePod(string rssUrl, string name)
        {
            Pod newPod = new Pod(rssUrl, name);
            newPod.Category = new Category();
            newPod.Title = podRepo.FetchPodTitleFromUrl(rssUrl);
            newPod.Description = podRepo.FetchPodDescriptionFromUrl(rssUrl);
            newPod.Episodes = podRepo.FetchEpisodesFromUrl(rssUrl);
            podRepo.Create(newPod);
        }

        public List<Pod> GetPodList()
        {
            return podRepo.GetAll();
        }
    }
}
