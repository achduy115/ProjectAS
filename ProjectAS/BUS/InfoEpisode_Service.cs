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

        /// <summary>
        /// Add a new info episode into db
        /// </summary>
        /// <param name="infoEpisode"></param>
        /// <returns></returns>
        public bool AddInfoEpisode(InfoEpisode_Model infoEpisode)
        {
            return InfoEpisode_Repository.Instance.InsertInfoEpisode(infoEpisode);
        }

        /// <summary>
        /// Check id InfoEpisode and return it
        /// </summary>
        /// <param name="idEpisode"></param>
        /// <returns></returns>
        public string CheckIdInfoEpisode(string idEpisode)
        {
            string id = "0001";

            List<string> listIdEpisode = InfoEpisode_Repository.Instance.GetIdInfoEpisodeByIdEpisode(idEpisode);

            if(listIdEpisode.Count == 0)
            {
                return idEpisode + id;
            }
            else
            {
                foreach(string item in listIdEpisode)
                {
                    id = item.Substring(11);
                }

                int temp = int.Parse(id);

                temp += 1;

                id = temp.ToString();

                if (id.Length == 1)
                {
                    return idEpisode + "000" + id;
                }
                else if (id.Length == 2)
                {
                    return idEpisode + "00" + id;
                }
                else if (id.Length == 3)
                {
                    return idEpisode + "0" + id;
                }
                else
                {
                    return idEpisode + id;
                }
            }


        }

    }
}
