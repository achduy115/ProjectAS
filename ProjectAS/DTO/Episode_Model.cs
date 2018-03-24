using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Episode_Model
    {
        public string ID { get; set; }
        public string IDAnime { get; set; }
        public string IDSubTeam { get; set; }

        public Episode_Model() { }

        public Episode_Model(string id, string idAnime, string idSubTeam)
        {
            this.ID = id;
            this.IDAnime = idAnime;
            this.IDSubTeam = idSubTeam;
        }

        public Episode_Model(DataRow rows)
        {
            this.ID = rows["id"].ToString();
            this.IDAnime = rows["idAnime"].ToString();
            this.IDSubTeam = rows["IDSubTeam"].ToString();
        }

    }
}
