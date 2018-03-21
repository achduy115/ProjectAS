using System;
using System.Collections.Generic;
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

    }
}
