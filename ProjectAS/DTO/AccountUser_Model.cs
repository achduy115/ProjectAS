using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountUser_Model
    {
        public int ID { get; set; }
        public string NameDisplay { get; set; }
        public string Email { get; set; }

        public AccountUser_Model() { }

        public AccountUser_Model(string nameDisplay, string email)
        {
            this.NameDisplay = nameDisplay;
            this.Email = email;
        }
    }
}
