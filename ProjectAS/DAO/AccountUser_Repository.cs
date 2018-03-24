using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class AccountUser_Repository
    {
        private static AccountUser_Repository instance;

        public static AccountUser_Repository Instance
        {
            get { if (instance == null) instance = new AccountUser_Repository(); return instance; }
            private set { instance = value; }
        }

        private AccountUser_Repository() { }

        //
    }
}
