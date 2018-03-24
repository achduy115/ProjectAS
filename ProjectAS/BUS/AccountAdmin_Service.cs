using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class AccountAdmin_Service
    {
        private static AccountAdmin_Service instance;

        public static AccountAdmin_Service Instance
        {
            get { if (instance == null) instance = new AccountAdmin_Service(); return instance; }
            private set { instance = value; }
        }

        private AccountAdmin_Service() { }

        //
    }
}
