using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SubTeam_Model
    {
        public string ID { get; set; }
        public string NameDisplay { get; set; }
        public string Info { get; set; }

        public SubTeam_Model() { }

        public SubTeam_Model(string id, string nameDisplay, string info)
        {
            this.ID = id;
            this.NameDisplay = nameDisplay;
            this.Info = info;
        }

        public SubTeam_Model(DataRow rows)
        {
            this.ID = rows["ID"].ToString();
            this.NameDisplay = rows["NameDisplay"].ToString();
            this.Info = rows["Info"].ToString();
        }

    }
}
