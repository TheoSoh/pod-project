using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IPodRepository<T> where T : class
    {
        List<Episode> FetchEpisodesFromUrl(string rssurl);
        public string FetchPodTitleFromUrl(string rssUrl);
        public string FetchPodDescriptionFromUrl(string rssUrl);
        public Pod GetByPodTitle(string title);
        public void DeletePodXml(string podTitle);
        List<T> GetAll();
        void Create(T item);
        void SaveChanges();
    }
}
