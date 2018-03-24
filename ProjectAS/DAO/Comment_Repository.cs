using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Comment_Repository
    {
        private static Comment_Repository instance;

        public static Comment_Repository Instance
        {
            get { if (instance == null) instance = new Comment_Repository(); return instance; }
            private set { instance = value; }
        }

        private Comment_Repository() { }

        //
    }
}
