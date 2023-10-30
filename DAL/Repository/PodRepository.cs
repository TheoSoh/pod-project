using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PodRepository : IPodRepository<Pod>
    {
        List<Pod> podList;
        Serializer<Pod> serializer;
        public PodRepository()
        {
            podList = new List<Pod>();
            serializer = new Serializer<Pod>(nameof(podList));
        }

        public List<Pod> GetAll()
        {
            List<Pod> podListDeserialized = new List<Pod>();
            try
            {
                podListDeserialized = serializer.Deserialize();
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
            return podListDeserialized;
        }

        public void Create(Pod aPod)
        {
            podList = GetAll();
            podList.Add(aPod);
            SaveChanges();
        }

        public string FetchPodTitleFromUrl(string rssUrl)
        {
            string podTitle = RssReader.FetchPodTitleFromUrl(rssUrl);
            return podTitle;
        }

        public string FetchPodDescriptionFromUrl(string rssUrl)
        {
            string podDescription = RssReader.FetchPodDescriptionFromUrl(rssUrl);
            return podDescription;
        }

        public List<Episode> FetchEpisodesFromUrl(string rssUrl)
        {
            List<Episode> episodes = RssReader.FetchEpisodesFromUrl(rssUrl);
            return episodes;
        }

        public void SaveChanges()
        {
            try
            {
                serializer.Serialize(podList);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public Pod GetByPodTitle(string title)
        {
            return GetAll().FirstOrDefault(pod => pod.Title.Equals(title));
        }

       public void update(int index, Pod pod)
        {
            podList[index] = pod;
            SaveChanges();
        }

        public void DeletePodXml(string podTitle)
        {
            RssReader.DeletePodXml(podTitle);
        }

    }
}
