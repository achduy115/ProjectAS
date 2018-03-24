using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class InfoComment_Service
    {
        private static InfoComment_Service instance;

        public static InfoComment_Service Instance
        {
            get { if (instance == null) instance = new InfoComment_Service(); return instance; }
            private set { instance = value; }
        }

        private InfoComment_Service() { }

        //
    }
}
