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

        // Get list AnimeCategory from database
        public List<AnimeCategory> getAnimeCategoryList()
        {
            List<AnimeCategory> list = new List<AnimeCategory>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LoadAnimeCategoryList");

            foreach (DataRow item in data.Rows)
            {
                AnimeCategory animeCategory = new AnimeCategory(item);
                list.Add(animeCategory);
            }

            return list;
        }

        // Get AnimeVategory from database
        public DataTable getAnimeCategory()
        {
            return DataProvider.Instance.ExecuteQuery("USP_LoadAnimeCategoryList");
        }

        // Insert a AnimeCategory into database
        public bool insertAnimeCategory(AnimeCategory category)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_InsertAnimeCategory @ID , @NameDisplay", 
                new object[] { category.ID, category.NameDisplay });

            return result > 0;
        }

        // Update a Anime Category by ID 
        public bool updateAnimeCategory(AnimeCategory category)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateAnimeCategory @ID , @NameDisplay",
                new object[] { category.ID, category.NameDisplay });

            return result > 0;
        }

        // Delete a Anime Category by ID
        public bool deleteAnimeCategory(string id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_DeleteAnimeCategory @ID ",
                new object[] { id});

            return result > 0;
        }


    }
}
