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

        // Load list anime category
        public List<AnimeCategory_Model> loadAnimeCategoryList()
        {
            return AnimeCategory_Repository.Instance.getAnimeCategoryList();
        }

        // Load anime category
        public DataTable loadAnimeCategory()
        {
            return AnimeCategory_Repository.Instance.getAnimeCategory();
        }

        // Add a anime category - WARNING
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

        // update a Anime Category - WARNING
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

        // delete a anime category - WARNING - Chưa ràng buộc xóa với các khóa ngoại
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
