using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Episode_Repository
    {
        private static Episode_Repository instance;

        public static Episode_Repository Instance
        {
            get { if (instance == null) instance = new Episode_Repository(); return instance; }
            private set { instance = value; }
        }

        private Episode_Repository() { }

        /// <summary>
        /// Get Episode list from db
        /// </summary>
        /// <returns></returns>
        public List<Episode_Model> GetEpisodeList()
        {
            List<Episode_Model> list = new List<Episode_Model>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.table_Episode");

            foreach(DataRow item in data.Rows)
            {
                Episode_Model episode = new Episode_Model(item);

                list.Add(episode);
            }

            return list;
        }

        /// <summary>
        /// Insert a new episode into db
        /// </summary>
        /// <param name="episode"></param>
        /// <returns></returns>
        public bool InsertEpisode(Episode_Model episode)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.table_Episode " +
                "VALUES ('" + episode.ID + "','" + episode.IDAnime + "','" + episode.IDSubTeam + "')");
            return result > 0;
        }

        /// <summary>
        /// Delete a Episode by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteEpisodeByID(string idEpisode)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.table_Episode " +
                "WHERE ID = '" + idEpisode + "'");
            return result > 0;
        }

        /// <summary>
        /// Get IdEpisode list from db
        /// </summary>
        /// <returns></returns>
        public List<String> GetIdEpisodeList()
        {
            List<String> list = new List<string>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT ID FROM dbo.table_Episode");

            foreach(DataRow item in data.Rows)
            {
                list.Add(item["id"].ToString());
            }

            return list;
        }

        /// <summary>
        /// Get a Episode by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Episode_Model GetEpisodeByID(string idEpisode)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.table_Episode " +
                "WHERE ID = '" + idEpisode + "'");
            return new Episode_Model(data.Rows[0]);
        }

        /// <summary>
        /// Get Episode list by id anime
        /// </summary>
        /// <param name="idAnime"></param>
        /// <returns></returns>
        public List<Episode_Model> GetEpisodeListByIdAnime(string idAnime)
        {
            List<Episode_Model> list = new List<Episode_Model>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.table_Episode " +
                "WHERE IDAnime = '" + idAnime + "'");

            foreach(DataRow item in data.Rows)
            {
                Episode_Model episode = new Episode_Model(item);

                list.Add(episode);
            }

            return list;
        }
    }
}
