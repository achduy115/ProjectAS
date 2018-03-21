using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WebView_Model
    {
        public int DayView { get; set; }
        public int WeekView { get; set; }
        public int MonthView { get; set; }
        public int TotalView { get; set; }

        public WebView_Model() { }

        public WebView_Model(int dayView, int weekView, int monthView, int totalView)
        {
            this.DayView = dayView;
            this.WeekView = weekView;
            this.MonthView = monthView;
            this.TotalView = totalView;
        }
    }
}
