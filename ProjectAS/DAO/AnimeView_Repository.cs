using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AnimeView_Repository
    {
        private static AnimeView_Repository instance;

        public static AnimeView_Repository Instance
        {
            get { if (instance == null) instance = new AnimeView_Repository(); return instance; }
            private set { instance = value; }
        }

        private AnimeView_Repository() { }

        /// <summary>
        /// Get anime view list
        /// </summary>
        /// <returns></returns>
        public List<AnimeView_Model> GetAnimeViewList()
        {
            List<AnimeView_Model> list = new List<AnimeView_Model>() { };

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.table_AnimeView");

            foreach(DataRow item in data.Rows)
            {
                AnimeView_Model animeView = new AnimeView_Model(item);
                list.Add(animeView);
            }

            return list;
        }

        /// <summary>
        /// Update a anime view by id anime
        /// </summary>
        /// <param name="animeView"></param>
        /// <returns></returns>
        public bool UpdateAnimeViewByIdAnime(AnimeView_Model animeView)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.table_AnimeView " +
                "SET DayView = '" + animeView.DayView + "', WeekView = '" + animeView.WeekView + "', " +
                "MonthView = '" + animeView.MonthView + "', TotalView = '" + animeView.TotalView + "' " +
                "WHERE IDAnime = '" + animeView.IDAnime + "'");
            return result > 0;
        }



    }
}
