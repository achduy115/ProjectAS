using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AnimeView_Model
    {
        public string IDAnime { get; set; }
        public int DayView { get; set; }
        public int WeekView { get; set; }
        public int MonthView { get; set; }
        public int TotalView { get; set; }

        public AnimeView_Model() { }

        public AnimeView_Model(string id, int dayView, int weekView, int monthView, int totalView)
        {
            this.IDAnime = id;
            this.DayView = dayView;
            this.WeekView = weekView;
            this.MonthView = monthView;
            this.TotalView = totalView;
        }

        public AnimeView_Model(DataRow rows)
        {
            this.IDAnime = rows["id"].ToString();
            this.DayView = int.Parse(rows["dayView"].ToString());
            this.WeekView = int.Parse(rows["weekView"].ToString());
            this.MonthView = int.Parse(rows["monthView"].ToString());
            this.TotalView = int.Parse(rows["totalView"].ToString());
        }
    }
}
