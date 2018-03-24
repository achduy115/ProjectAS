using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class InfoEpisode_Repository
    {
        private static InfoEpisode_Repository instance;

        public static InfoEpisode_Repository Instance
        {
            get { if (instance == null) instance = new InfoEpisode_Repository(); return instance; }
            private set { instance = value; }
        }

        private InfoEpisode_Repository() { }

        /// <summary>
        /// Get Episode list
        /// </summary>
        /// <returns></returns>
        public List<InfoEpisode_Model> GetInfoEpisodeList()
        {
            List<InfoEpisode_Model> list = new List<InfoEpisode_Model>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.table_InfoEpisode");

            foreach(DataRow item in data.Rows)
            {
                InfoEpisode_Model infoEpisode = new InfoEpisode_Model(item);
                list.Add(infoEpisode);
            }

            return list;
        }

        /// <summary>
        /// Get Episode list by ID
        /// </summary>
        /// <param name="idInfoEpisode"></param>
        /// <returns></returns>
        public List<InfoEpisode_Model> GetInfoEpisodeByID(string idInfoEpisode)
        {
            List<InfoEpisode_Model> list = new List<InfoEpisode_Model>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.table_InfoEpisode " +
                "WHERE ID = '" + idInfoEpisode + "'");

            foreach (DataRow item in data.Rows)
            {
                InfoEpisode_Model infoEpisode = new InfoEpisode_Model(item);
                list.Add(infoEpisode);
            }

            return list;
        }

        /// <summary>
        /// Get InfoEpisode by id episode
        /// </summary>
        /// <param name="idEpisode"></param>
        /// <returns></returns>
        public List<InfoEpisode_Model> GetInfoEpisodeByIdEpisode(string idEpisode)
        {
            List<InfoEpisode_Model> list = new List<InfoEpisode_Model>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.table_InfoEpisode " +
                "WHERE IDEpisode = '" + idEpisode + "'");

            foreach (DataRow item in data.Rows)
            {
                InfoEpisode_Model infoEpisode = new InfoEpisode_Model(item);
                list.Add(infoEpisode);
            }

            return list;
        }

        /// <summary>
        /// Get Id InfoEpisode by id Episode
        /// </summary>
        /// <param name="idEpisode"></param>
        /// <returns></returns>
        public List<string> GetIdInfoEpisodeByIdEpisode(string idEpisode)
        {
            List<string> list = new List<string>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT ID FROM dbo.table_InfoEpisode " +
                "WHERE IdEpisode = '" + idEpisode + "'");

            foreach(DataRow item in data.Rows)
            {
                list.Add(item["id"].ToString());
            }

            return list;
        }

        /// <summary>
        /// Insert a info episode into db
        /// </summary>
        /// <returns></returns>
        public bool InsertInfoEpisode(InfoEpisode_Model infoEpisode)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.table_InfoEpisode " +
                "VALUES ('"+ infoEpisode.ID + "','"+ infoEpisode.NameDisplay +"','"+ infoEpisode.IDEpisode +"','"+ infoEpisode.VideoUrl +"')");
            return result > 0;
        }

        /// <summary>
        /// Update a episode
        /// </summary>
        /// <param name="idInfoEpisode"></param>
        /// <returns></returns>
        public bool UpdateInfoEpisodeByID(InfoEpisode_Model infoEpisode)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.table_InfoEpisode " +
                "SET NameDisplay = '" + infoEpisode.NameDisplay + "', VideoUrl = '" + infoEpisode.VideoUrl + "'");
            return result > 0;
        }

        /// <summary>
        /// Delete a info episode by id
        /// </summary>
        /// <param name="idInfoEpisode"></param>
        /// <returns></returns>
        public bool DeleteInfoEpisodeByID(string idInfoEpisode)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.table_InfoEpisode " +
                "WHERE ID = '" + idInfoEpisode + "'");
            return result > 0;
        }

    }
}
