using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    public class Pod
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<Episode> Episodes { get; set; }
        public Pod() { }
        public Pod(string url, string name, string category)
        {
            Url = url;
            Name = name;
            Category = category;
        }
    }
}
