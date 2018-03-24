using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAS.View.Admin.Webform
{
    public partial class InfoEpisode : System.Web.UI.Page
    {
        string idEpisode;

        protected void Page_Load(object sender, EventArgs e)
        {          
            if (!IsPostBack)
            {
                GetID();
                LoadHeader();
            }
            else
            {

            }
        }

        #region Events

        #endregion

        #region Methods

        private void GetID()
        {
            idEpisode = Request.QueryString["idepisode"];
        }

        private void LoadHeader()
        {
            Episode_Model episode = Episode_Service.Instance.LoadEpisodeByID(idEpisode);
            Anime_Model anime = Anime_Service.Instance.LoadAnimeByID(episode.IDAnime);
            SubTeam_Model subTeam = SubTeam_Service.Instance.LoadSubTeamByID(episode.IDSubTeam);

            lbHeader.Text = anime.NameDisplay + " - " + subTeam.NameDisplay;

        }

        private void LoadInfoEpisode()
        {
            
        }


        #endregion

    }
}