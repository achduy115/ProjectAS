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
    public partial class InfoAnime : System.Web.UI.Page
    {
        string idAnime;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetID();
                LoadData();
            }
            else
            {
                CheckIdEpisodeAdded();
            }
        }

        #region Events

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteAnime())
            {
                //Success
            }
            else
            {
                //False
            }
        }

        protected void ddlSubTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckIdEpisodeAdded();
        }

        protected void btnAddSubTeam_Click(object sender, EventArgs e)
        {
            if(Episode_Service.Instance.CheckIdEpisodeAdded(txbID.Text + ddlSubTeam.SelectedValue))
            {
                if (AddEpisode())
                {
                    LoadData();
                }
                else
                {
                    // Error
                }
            }
            else
            {
                // Error
            }
            
        }

        #endregion

        #region Method

        private void LoadData()
        {
            LoadAnime();
            LoadSubTeam();
            LoadEpisode();
            CheckIdEpisodeAdded();
        }

        private void GetID()
        {
            idAnime = Request.QueryString["idanime"];
        }

        private void LoadAnime()
        {
            Anime_Model anime = Anime_Service.Instance.LoadAnimeByID(idAnime);
            lbAnimeName.Text = anime.NameDisplay;
            txbID.Text = anime.ID;
            txbContent.Text = anime.Content;
            txbCurrentEpisode.Text = anime.CurrentEpisode;
            txbMaxEpisode.Text = anime.MaxEpisode;
            imgAnime.ImageUrl = "~/Content/Image/Wallpaper/" + anime.ImageUrl;
        }

        private bool UpdateAnime()
        {
            string content = txbContent.Text;
            string currEpisode = txbCurrentEpisode.Text;
            string maxEpisode = txbMaxEpisode.Text;
            //string imgUrl = 
            return false;
        }

        private bool DeleteAnime() //
        {
            if (Anime_Service.Instance.DeleteAnime(idAnime))
                return true;
            return false;
        }

        private void LoadSubTeam()
        {
            List<SubTeam_Model> subTeam = SubTeam_Service.Instance.LoadSubTeam();
            foreach(SubTeam_Model item in subTeam)
            {
                ListItem li = new ListItem(item.NameDisplay, item.ID);
                ddlSubTeam.Items.Add(li);
            }
            ddlSubTeam.SelectedIndex = 0;
        }

        private bool AddEpisode()
        {
            string id = txbID.Text + ddlSubTeam.SelectedValue;
            string idSubTeam = ddlSubTeam.SelectedValue;
            string idAnime = txbID.Text;

            Episode_Model episode = new Episode_Model(id, idAnime, idSubTeam);

            if (Episode_Service.Instance.AddEpisode(episode))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void LoadEpisode()
        {
            dlEpisode.DataSource = Episode_Service.Instance.LoadEpisodeListByIdAnime(idAnime);
            dlEpisode.DataBind();
        }

        private void CheckIdEpisodeAdded()
        {
            if (Episode_Service.Instance.CheckIdEpisodeAdded(txbID.Text + ddlSubTeam.SelectedValue))
            {
                ddlSubTeam.CssClass = "w3-input w3-border w3-round w3-border-green w3-pale-green";
            }
            else
            {
                ddlSubTeam.CssClass = "w3-input w3-border w3-round w3-border-red w3-pale-red";
            }
        }

        #endregion
    }
}