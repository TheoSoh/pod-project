using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    internal static class RssReader
    {

        public static string FetchPodTitleFromUrl(string rssUrl)
        {
            string podTitle = "";
            SyndicationFeed synFeed = LoadSyndicationFeed(rssUrl);
            if (synFeed != null)
            {
                podTitle = synFeed.Title.Text;
            }
            else
            {
                Console.WriteLine("Error message: Unable to fetch the pod's title.");
            }
            return podTitle;
        }

        public static string FetchPodDescriptionFromUrl(string rssUrl)
        {
            string podDescription = "";
            SyndicationFeed synFeed = LoadSyndicationFeed(rssUrl);
            if (synFeed != null)
            {
                podDescription = synFeed.Description.Text;
            }
            else
            {
                Console.WriteLine("Error message: Unable to fetch the pod's description.");
            }
            return podDescription;
        }

        public static List<Episode> FetchEpisodesFromUrl(string rssUrl)
        {
            List<Episode> episodes = new List<Episode>();
            SyndicationFeed synFeed = LoadSyndicationFeed(rssUrl);
            if (synFeed != null)
            {
                foreach (SyndicationItem item in synFeed.Items)
                {
                    Episode episode = new Episode();
                    episode.Titel = item.Title.Text;
                    episode.Description = item.Summary.Text;
                    episode.PublishDate = item.PublishDate.ToString();
                    episode.EpisodeUrl = item.Links[0].Uri.ToString();

                    episodes.Add(episode);
                }
            }
            else
            {
                Console.WriteLine("Error message: Unable to fetch episodes.");
            }
            return episodes;
        }

        private static SyndicationFeed LoadSyndicationFeed(string rssUrl)
        {
            SyndicationFeed synFeed = null;
            try
            { 
                using (XmlReader reader = XmlReader.Create(rssUrl))
                {
                   synFeed = SyndicationFeed.Load(reader);
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            return synFeed;
        }
    }
}