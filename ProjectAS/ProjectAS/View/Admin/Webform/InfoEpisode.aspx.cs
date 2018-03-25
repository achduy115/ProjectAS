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
                Load();
            }
            else
            {

            }
        }

        #region Events

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if(txbNameDisplay.Text == "" || txbVideUrl.Text == "")
            {
                if(txbNameDisplay.Text == "")
                {
                    txbNameDisplay.CssClass = "w3-input w3-border w3-border-red w3-pale-red";
                    txbNameDisplay.Attributes.Add("placeholder","Xin hãy nhập tên tập phim. VD: 01, 02, OVA, SPC.");
                }
                if (txbVideUrl.Text == "")
                {
                    txbVideUrl.CssClass = "w3-input w3-border w3-border-red w3-pale-red";
                    txbVideUrl.Attributes.Add("placeholder", "Xin hãy nhập đường dẫn đến video.");
                }
            }
            else
            {
                if (AddInfoEpisde())
                {
                    // Success
                }
                else
                {
                    // Error
                }
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txbNameDisplay.Text = "";
            txbNameDisplay.CssClass = "w3-input w3-border";
            txbNameDisplay.Attributes.Add("placeholder", "01, 02, OVA, SPC");
            txbVideUrl.Text = "";
            txbVideUrl.CssClass = "w3-input w3-border";
            txbVideUrl.Attributes.Add("placeholder", "Đường dẫn đến video url");
        }

        #endregion

        #region Methods

        private void Load()
        {
            LoadHeader();
            LoadIdInfoEpisode();
        }

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

        private bool AddInfoEpisde()
        {
            return false;
        }

        private void LoadIdInfoEpisode()
        {
            txbID.Text = InfoEpisode_Service.Instance.CheckIdInfoEpisode(idEpisode);
        }

        #endregion

        
    }
}