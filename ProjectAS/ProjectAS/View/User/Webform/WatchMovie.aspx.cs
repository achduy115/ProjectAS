using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace ProjectAS.View.User.Webform
{
    public partial class WatchMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsCallback)
            {
                load_data();
            }
        }

        void load_data()
        {
//             string id = Request.QueryString["id"];
//             string cmd = "SELECT TA.ID,TA.Content,TIE.NameDisplay,TIE.VideoUrl FROM dbo.table_Anime AS TA, dbo.table_Episode AS TE, dbo.table_InfoEpisode AS TIE, dbo.table_SubTeam AS TST WHERE TA.ID = '" + id + " ' AND TE.IDAnime = TA.ID AND TE.IDSubTeam = TST.ID AND TIE.IDEpisode = TE.ID ";
//             DataListWatch.DataSource = DataProvider.Instance.ExecuteQuery(cmd);
//             DataListWatch.DataBind();
        }
    }
}