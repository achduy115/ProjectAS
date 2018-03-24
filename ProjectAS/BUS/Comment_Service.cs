using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class Comment_Service
    {
        private static Comment_Service instance;

        public static Comment_Service Instance
        {
            get { if (instance == null) instance = new Comment_Service(); return instance; }
            private set { instance = value; }
        }

        private Comment_Service() { }

        //
    }
}
