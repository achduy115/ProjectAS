using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class WebView_Repository
    {
        private static WebView_Repository instance;

        public static WebView_Repository Instance
        {
            get { if (instance == null) instance = new WebView_Repository(); return instance; }
            private set { instance = value; }
        }

        private WebView_Repository() { }

        //
    }
}
