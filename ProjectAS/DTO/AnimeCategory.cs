using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AnimeCategory
    {
        public string ID { get; set; }
        public string NameDisplay { get; set; }

        public AnimeCategory() { }

        public AnimeCategory(string id, string name)
        {
            this.ID = id;
            this.NameDisplay = name;
        }

        public AnimeCategory(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.NameDisplay = row["nameDisplay"].ToString();
        }
    }
}
