using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pod
    {

        public Pod(double amoutOfEpisodes, string title, string category, string fileName)
        {


            AmoutOfEpisodes = amoutOfEpisodes;
            Title = title;
            Category = category;
            FileName = fileName;
        }

    
        public double AmoutOfEpisodes {  get; set; }
        public string Title{ get; set; }
        public string Category{ get; set; }   
        public string FileName { get; }
    }
}
