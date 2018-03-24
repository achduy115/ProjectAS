using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using BUS;

namespace ProjectAS.View.User.Webform
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsCallback)
            {
                LoadData();
            }
        }

        void LoadData()
        {
            //string SlidesHome = "SELECT TOP 4 * FROM dbo.table_Anime";
            DataListSlides.DataSource = Anime_Service.Instance.LoadTopAnimeList(4);
            DataListSlides.DataBind();

            //string NewEpisode = "SELECT TOP 8 * FROM [table_Anime] ORDER BY [ID]";
            DataListNewEpisode.DataSource = Anime_Service.Instance.LoadTopAnimeListGroupByID(8);
            DataListNewEpisode.DataBind();

            //string NewAnime = "SELECT TOP 8 * FROM [table_Anime] ORDER BY [ID] DESC";
            DataListNewAnime.DataSource = Anime_Service.Instance.LoadTopAnimeListGroupByID(8, "DESC");
            DataListNewAnime.DataBind();

            //string Top = "SELECT TOP 8 * FROM [table_Anime] ORDER BY [ID]";
            DataListTop.DataSource = Anime_Service.Instance.LoadTopAnimeListGroupByID(8);
            DataListTop.DataBind();

            //string Random = "SELECT TOP 8 * FROM [table_Anime] ORDER BY RAND()";
//             DataListRandom.DataSource = DataProvider.Instance.ExecuteQuery(Random);
//             DataListRandom.DataBind();
        }
    }
}