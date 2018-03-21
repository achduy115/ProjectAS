using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountAmin_Model
    {
        public int ID { get; set; }
        public string NameDisplay { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public AccountAmin_Model() { }

        public AccountAmin_Model(string nameDisplay, string userName, string passWord)
        {
            this.NameDisplay = nameDisplay;
            this.UserName = userName;
            this.PassWord = passWord;
        }
    }
}
