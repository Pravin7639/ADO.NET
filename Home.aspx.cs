using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADODOTNetWebApp
{
    public partial class Home : System.Web.UI.Page
    {

        //Page Level Events
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtAspx.Text = "ASPX Textbox";
            //txtHtml.Value = "HTML Text";

            //if (IsPostBack)
            //{ 
            //    Response.Write("POST Request : Page_Load <br/>");
            //}
            //else
            //{
            //    Response.Write("GET Request : Page_Load <br/>");
            //}


        }
        protected void Page_Init(object sender, EventArgs e)
        {
           // Response.Write("Page_Init <br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            //Response.Write("Page_PreRender <br/>");
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            //Response.Write("btnLoad_Click <br/>");
        }
    }
}