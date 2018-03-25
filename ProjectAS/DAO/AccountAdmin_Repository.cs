using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class AccountAdmin_Repository
    {
        private static AccountAdmin_Repository instance;

        public static AccountAdmin_Repository Instance
        {
            get { if (instance == null) instance = new AccountAdmin_Repository(); return instance; }
            private set { instance = value; }
        }

        private AccountAdmin_Repository() { }

    }
}
