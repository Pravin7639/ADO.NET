using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADODOTNetWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGoogle_Click(object sender, EventArgs e)
        {
            //Server.Transfer("http://www.google.com");
            //Server.Execute("http://www.google.com");
           Response.Redirect("http://www.google.com");

        }

        protected void btnWebForm_Click(object sender, EventArgs e)
        {
            //Server.Transfer("WebForm2.aspx");
            //Server.Execute("WebForm2.aspx");
            Response.Redirect("WebForm2.aspx");

            lblMessage.Text = "WebForm 2 Page Proccessed Succcessfully";
        }
    }
}