using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class WebView_Service
    {
        private static WebView_Service instance;

        public static WebView_Service Instance
        {
            get { if (instance == null) instance = new WebView_Service(); return instance; }
            private set { instance = value; }
        }

        private WebView_Service() { }

        //
    }
}
