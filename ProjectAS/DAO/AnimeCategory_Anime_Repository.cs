using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class AnimeCategory_Anime_Repository
    {
        private static AnimeCategory_Anime_Repository instance;

        public static AnimeCategory_Anime_Repository Instance
        {
            get { if (instance == null) instance = new AnimeCategory_Anime_Repository(); return instance; }
            private set { instance = value; }
        }

        private AnimeCategory_Anime_Repository() { }

        /// <summary>
        /// Add a Anime Category - Anime
        /// </summary>
        /// <param name="animeCategory_Anime"></param>
        /// <returns></returns>
        public bool InsertAnimeCategory_Anime(AnimeCategory_Anime_Model animeCategory_Anime)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.table_AnimeCategory_Anime " +
                " VALUES ('"+ animeCategory_Anime.IdAnimeCategory +"', '"+ animeCategory_Anime.IdAnime +"')");
            return result > 0;
        }

        /// <summary>
        /// Delete a Anime Category - Anime by AnimeID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteAnimeCategory_AnimeByAnimeID(string id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.table_AnimeCategory_Anime " +
                " WHERE AnimeID = '" + id + "'");
            return result > 0;
        }

    }
}
