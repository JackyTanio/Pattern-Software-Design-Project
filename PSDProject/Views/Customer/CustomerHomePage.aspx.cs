using PSDProject.Controller;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views.Customer
{
    public partial class CustomerHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            MsUser curr = null;
          
            if (Session["user_session"] == null) Response.Redirect("~/Views/Login.aspx");
            else
            {
                curr = (MsUser)Session["user_session"];
                if (curr.UserRole == "Admin") Response.Redirect("~/Views/Admin/AdminHome.aspx");
           
                
            }



            GridView1.DataSource = StationeryController.getAll();
            GridView1.DataBind();

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}