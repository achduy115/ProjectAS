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
    public partial class Anime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadValue();
                LoadAnime();
            }
                
        }

        
        #region Events
        protected void lbSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbID.Text = Anime_Service.Instance.LoadID(lbSeason.SelectedValue, lbYear.SelectedValue);
        }

        protected void lbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbID.Text = Anime_Service.Instance.LoadID(lbSeason.SelectedValue, lbYear.SelectedValue);
        }

//         protected void gvAnimeList_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
//         {
//             gvAnimeList.EditIndex = -1;
//             LoadAnime();
//         }
// 
//         protected void gvAnimeList_RowDeleting(object sender, GridViewDeleteEventArgs e)
//         {
//             string id = gvAnimeList.DataKeys[e.RowIndex].Value.ToString();
//             if (Anime_Service.Instance.DeleteAnime(id))
//             {
//                 // Successs
//             }
//             else
//             {
//                 // Error
//             }
//             LoadAnime();
//             txbID.Text = Anime_Service.Instance.LoadID(lbSeason.SelectedValue, lbYear.SelectedValue);
// 
//         }
// 
//         protected void gvAnimeList_RowUpdating(object sender, GridViewUpdateEventArgs e)
//         {
//             string id = gvAnimeList.DataKeys[e.RowIndex].Value.ToString();
//             string name = (gvAnimeList.Rows[e.RowIndex].Cells[1].Controls[0] as TextBox).Text;
//             string imageUrl = (gvAnimeList.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox).Text;
//             string content = (gvAnimeList.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox).Text;
//             string currentEpisode = (gvAnimeList.Rows[e.RowIndex].Cells[4].Controls[0] as TextBox).Text;
//             string maxEpisode = (gvAnimeList.Rows[e.RowIndex].Cells[5].Controls[0] as TextBox).Text;
// 
//             Anime_Model anime = new Anime_Model(id, name, imageUrl, content, currentEpisode, maxEpisode);
//             if (Anime_Service.Instance.UpdateAnime(anime))
//             {
//                 // Success
//             }
//             else
//             {
//                 // Error
//             }
//             LoadAnime();
//             txbID.Text = Anime_Service.Instance.LoadID(lbSeason.SelectedValue, lbYear.SelectedValue);
// 
//         }

        protected void gvAnimeList_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvAnimeList.EditIndex = e.NewEditIndex;
            LoadAnime();
            txbID.Text = Anime_Service.Instance.LoadID(lbSeason.SelectedValue, lbYear.SelectedValue);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            AddAnime();
            LoadAnime();
            txbID.Text = Anime_Service.Instance.LoadID(lbSeason.SelectedValue, lbYear.SelectedValue);
        }

        #endregion

        #region Method
        private void LoadValue()
        {
            // List box season
            List<string> listSeason = new List<string>();
            listSeason.Add("SPI");
            listSeason.Add("SUM");
            listSeason.Add("FAL");
            listSeason.Add("WIN");

            lbSeason.DataSource = listSeason;
            lbSeason.DataBind();
            lbSeason.SelectedIndex = 0;

            // List box year
            List<string> listYear = new List<string>();
            listYear.Add("10");
            listYear.Add("11");
            listYear.Add("12");
            listYear.Add("13");
            listYear.Add("14");
            listYear.Add("15");
            listYear.Add("16");
            listYear.Add("17");
            listYear.Add("18");
            listYear.Add("19");
            listYear.Add("20");

            lbYear.DataSource = listYear;
            lbYear.DataBind();
            lbYear.SelectedIndex = 0;

            // Auto custom ID anime
            txbID.Text = Anime_Service.Instance.LoadID(lbSeason.SelectedValue, lbYear.SelectedValue);

            // Load Anime Category

            List<AnimeCategory_Model> list = AnimeCategory_Service.Instance.loadAnimeCategoryList();
            foreach (AnimeCategory_Model item in list)
            {
                ListItem li = new ListItem(item.NameDisplay, item.ID);
                lbCategory.Items.Add(li);
            }
            lbCategory.SelectedIndex = 0;
        }

        private void LoadAnime()
        {
            gvAnimeList.DataSource = Anime_Service.Instance.LoadAnimeList();
            gvAnimeList.DataBind();
        }

        private void AddAnime()
        {
            if (Utilities.CheckExtensionImg(flOpen.FileName))
            {
                lbFileName.Text = flOpen.FileName;
            }


            if (txbNameDisplay.Text == "" || txbContent.Text == "" || lbFileName.Text == "")
            {
                if(txbNameDisplay.Text == "")
                {
                    txbNameDisplay.CssClass += " w3-border-red w3-pale-red";
                    txbNameDisplay.Attributes.Add("placeholder", "Xin hãy nhập tên của anime");
                }
                if(txbContent.Text == "")
                {
                    txbContent.CssClass += " w3-border-red w3-pale-red";
                    txbContent.Attributes.Add("placeholder", "Xin hãy nhập nội dung của anime");
                }
                if(lbFileName.Text == "")
                {
                    lbFileName.CssClass += " w3-red";
                    lbFileName.Text = "Xin hãy chọn file";
                }
            }
            else
            {
                string id = txbID.Text;
                string name = txbNameDisplay.Text;
                string imageName = flOpen.FileName;

                UploadImg(flOpen.FileName);

                string content = txbContent.Text;
                Anime_Model anime = new Anime_Model(id, name, imageName, content);
                if (Anime_Service.Instance.AddAnime(anime, lbCategory.SelectedValue))
                {
                    txbResult.Text = "Thành công";
                    
                }
                else
                {
                    txbResult.Text = "Không thành công";
                }
            }
        }

        private void UploadImg(string fileName)
        {
            //lấy đường dẫn lưu hình
            string path = Server.MapPath("~/Content/Image/Wallpaper/");
            //Phương thức upload hình lên server
            flOpen.SaveAs(path + fileName);
        }

        #endregion
    }
}