using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class InfoEpisode_Service
    {
        private static InfoEpisode_Service instance;

        public static InfoEpisode_Service Instance
        {
            get { if (instance == null) instance = new InfoEpisode_Service(); return instance; }
            private set { instance = value; }
        }

        private InfoEpisode_Service() { }

        /// <summary>
        /// Load info Episode list by id Episode
        /// </summary>
        /// <param name="idInfoEpisode"></param>
        /// <returns></returns>
        public List<InfoEpisode_Model> LoadInfoEpisodeByIdEpisode(string idInfoEpisode)
        {
            return InfoEpisode_Repository.Instance.GetInfoEpisodeByIdEpisode(idInfoEpisode);
        }

       

    }
}
