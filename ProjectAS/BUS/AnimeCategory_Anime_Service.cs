using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class AnimeCategory_Anime_Service
    {
        private static AnimeCategory_Anime_Service instance;

        public static AnimeCategory_Anime_Service Instance
        {
            get { if (instance == null) instance = new AnimeCategory_Anime_Service(); return instance; }
            private set { instance = value; }
        }

        private AnimeCategory_Anime_Service() { }

        //
    }
}
