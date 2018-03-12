using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace ProjectAS.View.Admin.Webform
{
    public partial class AnimeCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                loadAnimeCategory();
            }
            

        }

        #region Events

        protected void btnAdd_Click(object sender, EventArgs e)
        {          
            string id = (txbID.Text).ToString();
            string name = (txbNameDisplay.Text).ToString();
            DTO.AnimeCategory category = new DTO.AnimeCategory(id, name);

            addAnimeCategory(category);
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbNameDisplay.Text = "";
        }

        protected void gvSummaryAnimeCategory_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string id = gvSummaryAnimeCategory.DataKeys[e.RowIndex].Value.ToString();
            string name = (gvSummaryAnimeCategory.Rows[e.RowIndex].Cells[1].Controls[0]
                as TextBox).Text;
            DTO.AnimeCategory category = new DTO.AnimeCategory(id, name);
            if (AnimeCategory_Service.Instance.updateAnimeCategory(category))
            {
                //Success
                gvSummaryAnimeCategory.EditIndex = -1;
            }
            else
            {
                //Error
            }
            loadAnimeCategory();
        }

        protected void gvSummaryAnimeCategory_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = gvSummaryAnimeCategory.DataKeys[e.RowIndex].Value.ToString();
            if (AnimeCategory_Service.Instance.deleteAnimeCategory(id))
            {
                //Success
                gvSummaryAnimeCategory.EditIndex = -1;
            }
            else
            {
                //Error
            }
            loadAnimeCategory();
        }

        protected void gvSummaryAnimeCategory_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvSummaryAnimeCategory.EditIndex = e.NewEditIndex;
            loadAnimeCategory();

        }

        protected void gvSummaryAnimeCategory_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvSummaryAnimeCategory.EditIndex = -1;
            loadAnimeCategory();
        }

        #endregion


        #region Method

        private void loadAnimeCategory()
        {
            gvSummaryAnimeCategory.DataSource = AnimeCategory_Service.Instance.loadAnimeCategoryList();
            gvSummaryAnimeCategory.DataBind();
        }

        private void addAnimeCategory(DTO.AnimeCategory category)
        {
            if (AnimeCategory_Service.Instance.addAnimeCategory(category))
            {
                txbResult.Text = "Thành công";
                txbID.Text = "";
                txbNameDisplay.Text = "";
                loadAnimeCategory();
            }
            else
            {
                txbResult.Text = "Không thành công";
                txbID.Text = "";
                txbNameDisplay.Text = "";
            }
        }


        #endregion

        
    }
}