using System;
using System.Collections.Generic;
using System.Data;
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
        
        public InfoEpisode_Model(string id, string nameDisplay, string videoUrl)
        {
            this.ID = id;
            this.NameDisplay = nameDisplay;
            this.VideoUrl = videoUrl;
        }

        public InfoEpisode_Model(DataRow rows)
        {
            this.ID = rows["id"].ToString();
            this.NameDisplay = rows["nameDisplay"].ToString();
            this.IDEpisode = rows["idEpisode"].ToString();
            this.VideoUrl = rows["videoUrl"].ToString();
        }
    }
}
