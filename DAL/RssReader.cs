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
            try
            {
                
                SyndicationFeed synFeed = LoadSyndicationFeed(rssUrl);
                if (synFeed != null)
                {
                    podTitle = synFeed.Title.Text;
                }
                else
                {
                    Console.WriteLine("Error message: Unable to fetch the pod's title.");
                }
                
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return podTitle;
        }

        public static string FetchPodDescriptionFromUrl(string rssUrl)
        {
            string podDescription = "";
            try
            {
                SyndicationFeed synFeed = LoadSyndicationFeed(rssUrl);
                if (synFeed != null)
                {
                    podDescription = synFeed.Description.Text;
                }
                else
                {
                    Console.WriteLine("Error message: Unable to fetch the pod's description.");
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return podDescription;
        }

        public static List<Episode> FetchEpisodesFromUrl(string rssUrl)
        {
            List<Episode> episodes = new List<Episode>();
            try
            {

                SyndicationFeed synFeed = LoadSyndicationFeed(rssUrl);
                if (synFeed != null)
                {
                    foreach (SyndicationItem item in synFeed.Items)
                    {
                        Episode episode = new Episode();
                        episode.Title = item.Title.Text;
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
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
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

        public static void UpdateXml (string categoryName, string newCategoryName)
        {
            try
            {
                var doc = XDocument.Load("podList.xml");

                var node = doc.Descendants("Pod").Where(pod => (string)pod.Element("Category") == categoryName);

                foreach (var podd in node)
                {
                    podd.SetElementValue("Category", newCategoryName);
                }


                doc.Save("podList.xml");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteCategoryXml (string categoryName)
        {
            try
            {
                var doc = XDocument.Load("podList.xml");
                var node = doc.Descendants("Pod").Where(pod => (string)pod.Element("Category") == categoryName);

                foreach (var podd in node)
                {
                    podd.SetElementValue("Category", "");
                }

                doc.Save("podList.xml");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Update(string currentCategoryName, string newCategoryName, string podTitle)
        {
            try
            {
                var doc = XDocument.Load("podList.xml");

                var node = doc.Descendants("Pod").Where(pod => (string)pod.Element("Title") == podTitle).FirstOrDefault();

                node.SetElementValue("Category", newCategoryName);

                doc.Save("podList.xml");
            }catch (Exception e) 
            { 
                Console.WriteLine(e.Message);
            }
        }

        public static void UpdateNameXml(string currentName, string newName, string podTitle)
        {
            try
            {
                var doc = XDocument.Load("podList.xml");
                var node = doc.Descendants("Pod").Where(pod => (string)pod.Element("Title") == podTitle).FirstOrDefault();

                node.SetElementValue("Name", newName);

                doc.Save("podList.xml");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public static void DeletePodXml(string podTitle)
        {
            try
            {

                var doc = XDocument.Load("podList.xml");
                var node = doc.Descendants("Pod").Where(pod => (string)pod.Element("Title") == podTitle).ToList();

                foreach (var podd in node)
                {
                    podd.Remove();
                }

                doc.Save("podList.xml");

            }catch(Exception e)
            { 
                Console.WriteLine(e.Message); 
            }

        }

    }
}