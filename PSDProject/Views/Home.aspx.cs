using PSDProject.Controller;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class Home : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            welcomeText.Text = "Welcome, Guest";

            stationeryGV.DataSource = StationeryController.getAll();
            stationeryGV.DataBind();

            
        }
    }
}