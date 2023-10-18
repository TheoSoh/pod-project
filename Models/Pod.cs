using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Pod
    {

        public Pod(string title,string url)
        {

            Title = title;
            FileName = url;
            
        }

        public Pod()
        {

        }

    
        public double AmoutOfEpisodes {  get; set; }
        public string Title{ get; set; }
        public string Category{ get; set; }   
        public string FileName { get; }
    }
}
