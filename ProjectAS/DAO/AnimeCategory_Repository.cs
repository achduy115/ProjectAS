using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace DAO
{
    public class AnimeCategory_Repository
    {
        private static AnimeCategory_Repository instance;

        public static AnimeCategory_Repository Instance
        {
            get { if (instance == null) instance = new AnimeCategory_Repository(); return instance; }
            private set { instance = value; }
        }

        private AnimeCategory_Repository() { }

        /// <summary>
        /// Get list AnimeCategory from database
        /// </summary>
        /// <returns></returns>
        public List<AnimeCategory_Model> getAnimeCategoryList()
        {
            List<AnimeCategory_Model> list = new List<AnimeCategory_Model>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LoadAnimeCategoryList");

            foreach (DataRow item in data.Rows)
            {
                AnimeCategory_Model animeCategory = new AnimeCategory_Model(item);
                list.Add(animeCategory);
            }

            return list;
        }

        /// <summary>
        /// Get AnimeVategory from database
        /// </summary>
        /// <returns></returns>
        public DataTable getAnimeCategory()
        {
            return DataProvider.Instance.ExecuteQuery("USP_LoadAnimeCategoryList");
        }

        /// <summary>
        /// Insert a AnimeCategory into database
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool insertAnimeCategory(AnimeCategory_Model category)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_InsertAnimeCategory @ID , @NameDisplay", 
                new object[] { category.ID, category.NameDisplay });

            return result > 0;
        }

        /// <summary>
        /// Update a Anime Category by ID 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool updateAnimeCategoryByID(AnimeCategory_Model category)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateAnimeCategory @ID , @NameDisplay",
                new object[] { category.ID, category.NameDisplay });

            return result > 0;
        }

        /// <summary>
        /// Delete a Anime Category by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool deleteAnimeCategoryByID(string id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_DeleteAnimeCategory @ID ",
                new object[] { id});

            return result > 0;
        }


    }
}
