using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    public class Episode
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PublishDate { get; set; }
        public string EpisodeUrl { get; set; }

        public Episode() { }

    }
}