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

        /// <summary>
        /// Get list anime from database
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Get Only ID from DB
        /// </summary>
        /// <returns></returns>
        public List<string> GetAnimeIDList()
        {
            List<string> list = new List<string>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT ID FROM dbo.table_Anime");

            foreach (DataRow item in data.Rows)
            {
                list.Add(item["id"].ToString());
            }

            return list;
        }

        /// <summary>
        /// Insert a anime into database
        /// </summary>
        /// <param name="anime"></param>
        /// <returns></returns>
        public bool InsertAnime(Anime_Model anime)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_InsertAnime @ID , @NameDisplay , @ImageUrl , @Content",
                new object[] { anime.ID, anime.NameDisplay, anime.ImageUrl, anime.Content });
            return result > 0;
        }

        /// <summary>
        /// Update a anime
        /// </summary>
        /// <param name="anime"></param>
        /// <returns></returns>        
        public bool UpdateAnimeByID(Anime_Model anime)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateAnime @ID , @NameDisplay , @ImageUrl , @Content , @CurrentEpisode , @MaxEpisode",
                new object[] { anime.ID, anime.NameDisplay, anime.ImageUrl, anime.Content, anime.CurrentEpisode, anime.MaxEpisode });
            return result > 0;
        }

        /// <summary>
        /// Delete a anime
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteAnimeByID(string id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_DeleteAnime @ID",
                new object[] { id });
            return result > 0;
        }

        /// <summary>
        /// Get list anime order by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="number">Number get</param>
        /// <returns></returns>
        public List<Anime_Model> GetAnimeListOrderByID(int number, string something = "")
        {
            List<Anime_Model> list = new List<Anime_Model>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT TOP " + number + " * FROM [table_Anime] ORDER BY [ID] " + something );

            foreach(DataRow item in data.Rows)
            {
                Anime_Model anime = new Anime_Model(item);

                list.Add(anime);
            }

            return list;
        }

        /// <summary>
        /// Get top anime follow the number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public List<Anime_Model> GetTopAnimeList(int number)
        {
            List<Anime_Model> list = new List<Anime_Model>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT TOP " + number + " * FROM table_Anime");

            foreach (DataRow item in data.Rows)
            {
                Anime_Model anime = new Anime_Model(item);

                list.Add(anime);
            }

            return list;
        }

        /// <summary>
        /// Get a anime by id and return Anime_Model
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Anime_Model GetAnimeByID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.table_Anime WHERE ID = '" + id + "'");

            return new Anime_Model(data.Rows[0]);          
        }



    }
}
