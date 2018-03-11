using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAS.View.Admin.Webform
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(txbUserName.Text == "" || txbPassword.Text == "")
            {
                if(txbUserName.Text == "")
                {
                    txbUserName.CssClass += " error";
                    txbUserName.Attributes.Add("placeholder", "Xin hãy nhập tên đăng nhập");
                }                 
                if(txbPassword.Text == "")
                {
                    txbPassword.CssClass += " error";
                    txbPassword.Attributes.Add("placeholder", "Xin hãy nhập mật khẩu");
                }                 
            }
            else
            {

            }
        }
    }
}