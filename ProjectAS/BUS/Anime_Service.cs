using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Anime_Service
    {
        private static Anime_Service instance;

        public static Anime_Service Instance
        {
            get { if (instance == null) instance = new Anime_Service(); return instance; }
            private set { instance = value; }
        }

        private Anime_Service() { }

        /// <summary>
        /// Load anime list
        /// </summary>
        /// <returns></returns>
        public List<Anime_Model> LoadAnimeList()
        {
            return Anime_Repository.Instance.GetAnimeList();
        }

        /// <summary>
        /// Add a anime - WARNING
        /// </summary>
        /// <param name="anime"></param>
        /// <param name="idAnimeCategory"></param>
        /// <returns></returns>
        public bool AddAnime(Anime_Model anime, string idAnimeCategory)
        {
            if (Anime_Repository.Instance.InsertAnime(anime))
            {
                AnimeCategory_Anime_Model animeCategory_Anime = new AnimeCategory_Anime_Model(idAnimeCategory, anime.ID);
                AnimeCategory_Anime_Repository.Instance.InsertAnimeCategory_Anime(animeCategory_Anime);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check and load ID
        /// </summary>
        /// <param name="_season"></param>
        /// <param name="_year"></param>
        /// <returns></returns>
        public string LoadID(string _season, string _year)
        {
            string _id = "000";

            List<string> list = Anime_Repository.Instance.GetAnimeIDList();
            foreach(string item in list)
            {
                string season = item.Substring(0, 3);
                string year = item.Substring(3, 2);
                
                if((_season + _year).Equals(season + year))
                {
                    string id = item.Substring(5);
                    _id = id;
                }

            }

            int temp = int.Parse(_id);

            temp += 1;

            _id = temp.ToString();

            if (_id.Length == 1)
            {
                return _season + _year + "00" + _id.ToString();
            }
            else if(_id.Length == 2)
            {
                return _season + _year + "0" + _id.ToString();
            }
            else
            {
                return _season + _year + _id.ToString();
            }
        }

        /// <summary>
        /// Delete a anime - WARNNING - Chưa xóa rằng buộc
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteAnime(string id) //
        {
            if (AnimeCategory_Anime_Repository.Instance.DeleteAnimeCategory_AnimeByAnimeID(id))
            {
                if (Anime_Repository.Instance.DeleteAnimeByID(id))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Update a anime - WARNING
        /// </summary>
        /// <param name="anime"></param>
        /// <returns></returns>
        public bool UpdateAnime(Anime_Model anime)
        {
            if (Anime_Repository.Instance.UpdateAnimeByID(anime))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Load top number anime
        /// </summary>
        /// <returns></returns>
        public List<Anime_Model> LoadTopAnimeList(int number)
        {
            return Anime_Repository.Instance.GetTopAnimeList(number);
        }

        /// <summary>
        /// Load top number anime and group by id
        /// </summary>
        /// <param name="id">Group by Id</param>
        /// <param name="number">The number get</param>
        /// <param name="something">Something else</param>
        /// <returns></returns>
        public List<Anime_Model> LoadTopAnimeListGroupByID(int number, string something = "")
        {
            return Anime_Repository.Instance.GetAnimeListOrderByID(number, something);
        }

        public Anime_Model LoadAnimeByID(string id)
        {
            return Anime_Repository.Instance.GetAnimeByID(id);
        }

    }
}
