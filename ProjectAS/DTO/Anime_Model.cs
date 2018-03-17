using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Anime_Model
    {
        public string ID { get; set; }
        public string NameDisplay { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public string CurrentEpisode { get; set; }
        public string MaxEpisode { get; set; }

        public Anime_Model() { }

        public Anime_Model(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.NameDisplay = row["nameDisplay"].ToString();
            this.ImageUrl = row["imageUrl"].ToString();
            this.Content = row["content"].ToString();
            this.CurrentEpisode = row["currentEpisode"].ToString();
            this.MaxEpisode = row["maxEpisode"].ToString();
        }

        public Anime_Model(string id, string nameDisplay, string imageUrl, string content)
        {
            this.ID = id;
            this.NameDisplay = nameDisplay;
            this.ImageUrl = imageUrl;
            this.Content = content;
        }

        public Anime_Model(string id, string nameDisplay, string imageUrl, string content, string current, string max)
        {
            this.ID = id;
            this.NameDisplay = nameDisplay;
            this.ImageUrl = imageUrl;
            this.Content = content;
            this.CurrentEpisode = current;
            this.MaxEpisode = max;
        }

    }
}
