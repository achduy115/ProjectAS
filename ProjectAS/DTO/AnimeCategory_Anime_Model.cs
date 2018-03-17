using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AnimeCategory_Anime_Model
    {
        public string IdAnimeCategory { get; set; }
        public string IdAnime { get; set; }

        public AnimeCategory_Anime_Model() { }

        public AnimeCategory_Anime_Model(string idAnimeCategory, string idAnime)
        {
            this.IdAnimeCategory = idAnimeCategory;
            this.IdAnime = idAnime;
        }
    }
}
