using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Episode_Service
    {
        private static Episode_Service instance;

        public static Episode_Service Instance
        {
            get { if (instance == null) instance = new Episode_Service(); return instance; }
            private set { instance = value; }
        }

        private Episode_Service() { }

        /// <summary>
        /// Load Episode to Client
        /// </summary>
        /// <returns></returns>
        public List<Episode_Model> LoadEpisodeList()
        {
            return Episode_Repository.Instance.GetEpisodeList();
        }

        /// <summary>
        /// Load episode by idEpisode
        /// </summary>
        /// <param name="idEpisode"></param>
        /// <returns></returns>
        public Episode_Model LoadEpisodeByID(string idEpisode)
        {
            return Episode_Repository.Instance.GetEpisodeByID(idEpisode);
        }

        /// <summary>
        /// Add a new Episode
        /// </summary>
        /// <param name="episode"></param>
        /// <returns></returns>
        public bool AddEpisode(Episode_Model episode)
        {
            return Episode_Repository.Instance.InsertEpisode(episode);
        }

        /// <summary>
        /// Delete a Episode by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteEpisodeByID(string id)
        {
            return Episode_Repository.Instance.DeleteEpisodeByID(id);
        }

        /// <summary>
        /// Check Id Episode
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckIdEpisodeAdded(string id)
        {
            List<string> idEpisode = Episode_Repository.Instance.GetIdEpisodeList();

            foreach(string item in idEpisode)
            {
                if (id.Equals(item))
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Load Episode list by Id anime
        /// </summary>
        /// <param name="idAnime"></param>
        /// <returns></returns>
        public List<Episode_Model> LoadEpisodeListByIdAnime(string idAnime)
        {
            return Episode_Repository.Instance.GetEpisodeListByIdAnime(idAnime);
        }

    }
}
