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
    public partial class SubTeam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadSubTeam();
        }

        #region Events

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            AddSubTeam();
            LoadSubTeam();
        }

        protected void gvSubTeam_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvSubTeam.EditIndex = -1;
            LoadSubTeam();
        }

        protected void gvSubTeam_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = gvSubTeam.DataKeys[e.RowIndex].Value.ToString();

            if (SubTeam_Service.Instance.DeleteSubTeamByID(id))
            {
                // Success
            }
            else
            {
                // Error
            }
            LoadSubTeam();
        }

        protected void gvSubTeam_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string id = gvSubTeam.DataKeys[e.RowIndex].Value.ToString();
            string name = (gvSubTeam.Rows[e.RowIndex].Cells[1].Controls[0] as TextBox).Text;
            string info = (gvSubTeam.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox).Text;

            SubTeam_Model subTeam = new SubTeam_Model(id, name, info);
            if (SubTeam_Service.Instance.UpdateSubTeamByID(subTeam))
            {
                // Success
            }
            else
            {
                // Error
            }
            LoadSubTeam();
        }

        protected void gvSubTeam_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvSubTeam.EditIndex = e.NewEditIndex;
            LoadSubTeam();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Load all Subteam
        /// </summary>
        private void LoadSubTeam()
        {
            gvSubTeam.DataSource = SubTeam_Service.Instance.LoadSubTeam();
            gvSubTeam.DataBind();
        }

        /// <summary>
        /// Add a Sub Team
        /// </summary>
        private void AddSubTeam()
        {
            if (txbID.Text == "" || txbNameDisplay.Text == "" || txbInfo.Text == "")
            {
                if (txbID.Text == "")
                {
                    txbID.CssClass += " w3-border-red w3-pale-red";
                    txbID.Attributes.Add("placeholder", "Xin hãy nhập mã sub team");
                }
                if (txbNameDisplay.Text == "")
                {
                    txbNameDisplay.CssClass += " w3-border-red w3-pale-red";
                    txbNameDisplay.Attributes.Add("placeholder", "Xin hãy nhập tên nhóm sub");
                }
                if (txbInfo.Text == "")
                {
                    txbInfo.CssClass += " w3-border-red w3-pale-red";
                    txbInfo.Attributes.Add("placeholder", "Xin hãy nhập thông tin nhóm sub");
                }
            }
            else
            {
                string id = txbID.Text;
                string name = txbNameDisplay.Text;
                string info = txbInfo.Text;

                SubTeam_Model subTeam = new SubTeam_Model(id, name, info);

                if (SubTeam_Service.Instance.AddSubTeam(subTeam))
                {
                    // Success
                }
                else
                {
                    // Error
                }
            }
        }



        #endregion


    }
}