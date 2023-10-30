using HtmlAgilityPack;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

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
                    episode.Title = item.Title.Text;

                    var summary = item.Summary?.Text;
                    var content = item.Content?.ToString();
                    if (summary != null)
                    {
                        HtmlDocument doc = new HtmlDocument();
                        doc.LoadHtml(summary);
                        episode.Description = doc.DocumentNode.InnerText;
                    }
                    else if (content != null)
                    {
                        HtmlDocument doc = new HtmlDocument();
                        doc.LoadHtml(content);
                        episode.Description = doc.DocumentNode.InnerText.ToString();
                    }

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
                using (XmlReader reader = XmlReader.Create(rssUrl))
                {
                   synFeed = SyndicationFeed.Load(reader);
                }
            return synFeed;
        }

        public static void UpdateXml (string categoryName, string newCategoryName)
        {
                var doc = XDocument.Load("podList.xml");

                var node = doc.Descendants("Pod").Where(pod => (string)pod.Element("Category") == categoryName);

                foreach (var podd in node)
                {
                    podd.SetElementValue("Category", newCategoryName);
                }


                doc.Save("podList.xml");
        }

        public static void DeleteCategoryXml (string categoryName)
        {
          
                var doc = XDocument.Load("podList.xml");
                var node = doc.Descendants("Pod").Where(pod => (string)pod.Element("Category") == categoryName);

                foreach (var podd in node)
                {
                    podd.SetElementValue("Category", "");
                }

                doc.Save("podList.xml");
        }

        public static void Update(string currentCategoryName, string newCategoryName, string podTitle)
        {
           
                var doc = XDocument.Load("podList.xml");

                var node = doc.Descendants("Pod").Where(pod => (string)pod.Element("Title") == podTitle).FirstOrDefault();

                node.SetElementValue("Category", newCategoryName);

                doc.Save("podList.xml");
        }

        public static void UpdateNameXml(string currentName, string newName, string podTitle)
        {
            
                var doc = XDocument.Load("podList.xml");
                var node = doc.Descendants("Pod").Where(pod => (string)pod.Element("Title") == podTitle).FirstOrDefault();

                node.SetElementValue("Name", newName);

                doc.Save("podList.xml");
        }


        public static void DeletePodXml(string podTitle)
        {
           

                var doc = XDocument.Load("podList.xml");
                var node = doc.Descendants("Pod").Where(pod => (string)pod.Element("Title") == podTitle).ToList();

                foreach (var podd in node)
                {
                    podd.Remove();
                }

                doc.Save("podList.xml");


        }

    }
}