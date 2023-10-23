using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IPodRepository<T> : IRepository<T> where T : Pod
    {
        List<Episode> FetchEpisodesFromUrl(string rssurl);
        public string FetchPodTitleFromUrl(string rssUrl);
        public string FetchPodDescriptionFromUrl(string rssUrl);
    }
}
