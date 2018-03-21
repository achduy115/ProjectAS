using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Comment_Model
    {
        public int ID { get; set; }
        public string IDAnime { get; set; }

        public Comment_Model() { }

        public Comment_Model(int id, string idAnime)
        {
            this.ID = id;
            this.IDAnime = idAnime;
        }

    }
}
