using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InfoEpisode_Model
    {
        public string ID { get; set; }
        public string NameDisplay { get; set; }
        public string IDEpisode { get; set; }
        public string VideoUrl { get; set; }

        public InfoEpisode_Model(){}

        public InfoEpisode_Model(string id, string nameDisplay, string idEpisode, string videoUrl){
        	this.ID = id;
        	this.NameDisplay = nameDisplay;
        	this.IDEpisode = idEpisode;
        	this.VideoUrl = videoUrl;
        }
    }
}
