using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InfoComment_Model
    {
        public int ID { get; set; }
        public int IDComment { get; set; }
        public int IDAccountUser { get; set; }
        public string Info { get; set; }
        public bool Checked { get; set; }

        public InfoComment_Model() { }

        public InfoComment_Model(int id, int idComment, int idAccountUser, string info)
        {
            this.ID = id;
            this.IDComment = idComment;
            this.IDAccountUser = idAccountUser;
            this.Info = info;
        }

    }
}
