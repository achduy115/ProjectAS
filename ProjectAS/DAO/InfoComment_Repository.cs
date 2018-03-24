using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class InfoComment_Repository
    {
        private static InfoComment_Repository instance;

        public static InfoComment_Repository Instance
        {
            get { if (instance == null) instance = new InfoComment_Repository(); return instance; }
            private set { instance = value; }
        }

        private InfoComment_Repository() { }

        //
    }
}
