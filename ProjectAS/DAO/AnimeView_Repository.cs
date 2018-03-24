using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class AnimeView_Repository
    {
        private static AnimeView_Repository instance;

        public static AnimeView_Repository Instance
        {
            get { if (instance == null) instance = new AnimeView_Repository(); return instance; }
            private set { instance = value; }
        }

        private AnimeView_Repository() { }

        //
    }
}
