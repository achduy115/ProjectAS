using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class AccountUser_Service
    {
        private static AccountUser_Service instance;

        public static AccountUser_Service Instance
        {
            get { if (instance == null) instance = new AccountUser_Service(); return instance; }
            private set { instance = value; }
        }

        private AccountUser_Service() { }

        //
    }
}
