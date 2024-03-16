using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADODOTNetWebApp
{
    public partial class StateMaintaining2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////ViewState["number"] 
            //if (!IsPostBack)
            //{
            //    if(ViewState["number"] != null)
            //    {
            //        lblMessage.Text = ViewState["number"].ToString();
            //    }
            //    else
            //    {
            //        lblMessage.Text = "Empty View State";
            //    }
            //}







            ///// Reading Cookies from StateMaintaining1.aspx.cs

            //HttpCookie user1 = Request.Cookies["B22UserInfo"];

            //if (user1 != null)
            //{
            //    lblName.Text = user1["name"];
            //    lblEmail.Text = user1["email"];
            //}
            //else
            //{
            //    lblName.Text = "No Name Found";
            //    lblEmail.Text = "No Email Found";
            //}




            ////read Query String

            //if(Request.QueryString["name"] != null)
            //{
            //    lblName.Text = Request.QueryString["name"];
            //}
            //else
            //{
            //    lblName.Text = "No Name Found";
            //}

            //if (Request.QueryString["email"] != null)
            //{
            //    lblEmail.Text = Request.QueryString["email"];
            //}
            //else
            //{
            //    lblEmail.Text = "No Email Found";
            //}





            //reading from session 
            if(Session["name"] != null)
            {
                lblName.Text = Session["name"].ToString();
            }
            else
            {
                lblName.Text = "No Name Found";
            }


            if (Session["email"] != null)
            {
                lblEmail.Text = Session["email"].ToString();
            }
            else
            {
                lblEmail.Text = "No Email Found";
            }



        }
    }
}