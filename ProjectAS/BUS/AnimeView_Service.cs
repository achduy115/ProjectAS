using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class AnimeView_Service
    {
        private static AnimeView_Service instance;

        public static AnimeView_Service Instance
        {
            get { if (instance == null) instance = new AnimeView_Service(); return instance; }
            private set { instance = value; }
        }

        private AnimeView_Service() { }

        //
    }
}
