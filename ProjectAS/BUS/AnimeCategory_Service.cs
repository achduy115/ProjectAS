using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class AnimeCategory_Service
    {
        private static AnimeCategory_Service instance;

        public static AnimeCategory_Service Instance
        {
            get { if (instance == null) instance = new AnimeCategory_Service(); return instance; }
            private set { instance = value; }
        }

        private AnimeCategory_Service() { }

        /// <summary>
        /// Load list anime category
        /// </summary>
        /// <returns></returns>
        public List<AnimeCategory_Model> loadAnimeCategoryList()
        {
            return AnimeCategory_Repository.Instance.getAnimeCategoryList();
        }

        /// <summary>
        /// Load anime category
        /// </summary>
        /// <returns></returns>
        public DataTable loadAnimeCategory()
        {
            return AnimeCategory_Repository.Instance.getAnimeCategory();
        }

        /// <summary>
        /// Add a anime category - WARNING
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool addAnimeCategory(AnimeCategory_Model category)
        {
            if (category.ID == "" || category.NameDisplay == "")
            {
                return false;
            }
            else
            {
                foreach (AnimeCategory_Model item in loadAnimeCategoryList())
                {
                    if (category.ID == item.ID || category.NameDisplay == item.NameDisplay)
                    {
                        return false;
                    }
                }
                return AnimeCategory_Repository.Instance.insertAnimeCategory(category);
            }
        }

        /// <summary>
        /// update a Anime Category - WARNING
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool updateAnimeCategory(AnimeCategory_Model category)
        {
            if (category.NameDisplay == "")
            {
                return false;
            }
            else
            {
                foreach (AnimeCategory_Model item in loadAnimeCategoryList())
                {
                    if (category.NameDisplay == item.NameDisplay)
                    {
                        return false;
                    }
                }
                return AnimeCategory_Repository.Instance.updateAnimeCategoryByID(category);
            }
        }

        /// <summary>
        /// delete a anime category - WARNING - Chưa ràng buộc xóa với các khóa ngoại
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool deleteAnimeCategory(string id)
        {
            if (AnimeCategory_Repository.Instance.deleteAnimeCategoryByID(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
