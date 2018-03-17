using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Anime_Repository
    {
        private static Anime_Repository instance;

        public static Anime_Repository Instance
        {
            get { if (instance == null) instance = new Anime_Repository(); return instance; }
            private set { instance = value; }
        }

        private Anime_Repository() { }

        // Get list anime from database
        public List<Anime_Model> GetAnimeList()
        {
            List<Anime_Model> list = new List<Anime_Model>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LoadAnimeList");

            foreach (DataRow item in data.Rows)
            {
                Anime_Model anime = new Anime_Model(item);

                list.Add(anime);
            }

            return list;
        }

        // Get Only ID from DB
        public List<string> GetAnimeIDList()
        {
            List<string> list = new List<string>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT ID FROM dbo.table_Anime");

            foreach(DataRow item in data.Rows)
            {
                list.Add(item["id"].ToString());
            }

            return list;
        }

        // Insert a anime into database
        public bool InsertAnime(Anime_Model anime)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_InsertAnime @ID , @NameDisplay , @ImageUrl , @Content",
                new object[] { anime.ID, anime.NameDisplay, anime.ImageUrl, anime.Content });
            return result > 0;
        }

        // Update a anime 
        public bool UpdateAnimeByID(Anime_Model anime)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateAnime @ID , @NameDisplay , @ImageUrl , @Content , @CurrentEpisode , @MaxEpisode",
                new object[] { anime.ID, anime.NameDisplay, anime.ImageUrl, anime.Content, anime.CurrentEpisode, anime.MaxEpisode });
            return result > 0;
        }

        // Delete a anime
        public bool DeleteAnimeByID(string id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_DeleteAnime @ID", 
                new object[] { id });
            return result > 0;
        }

    }
}
