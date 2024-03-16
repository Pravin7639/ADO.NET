using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADODOTNetWebApp
{
    public partial class StateMaintaining1 : System.Web.UI.Page
    {
       // int number = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            ////   txtNumber.Text = number.ToString();
            
            //txtNumber.Text = hdnNumber.Value;          /// for hidden fields

            //if (!IsPostBack)                     //// for ViewState
            //{
            //    ViewState["number"] = 0;
            //    txtNumber.Text = ViewState["number"].ToString();
            //}
        
        }

        //protected void btnIncrement_Click(object sender, EventArgs e)
       // {
            //////    number++;
            //////  txtNumber.Text = number.ToString();


            ////int num = int.Parse(hdnNumber.Value);    /// for Hidden Fields
            ////num++;
            ////hdnNumber.Value = num.ToString();
            ////txtNumber.Text = hdnNumber.Value;



            //int num = (int) ViewState["number"];             // for ViewState
            //num++;

            //ViewState["number"] = num;
            //txtNumber.Text = ViewState["number"].ToString();
            //// value gets stored in encripted format 
            //// stored base 64 format


       // }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;

            ////// using Coocies
            ////HttpCookie user = new HttpCookie("B22UserInfo");
            ////user["name"] = name;
            ////user["email"] = email;
            ////user.Expires = DateTime.Now.AddDays(1);  // Adding Expiration Time
            ////Response.Cookies.Add(user);
            ////Response.Redirect("StateMaintaining2.aspx");


            ////Using Query String

            //name = HttpUtility.UrlEncode(name);
            //email = HttpUtility.UrlEncode(email);

            //string url = $"StateMaintaining2.aspx?name={name}&email={email}";

            //Response.Redirect(url); 



            //using session

            Session["name"] = name;
            Session["email"] = email;

            Response.Redirect("StateMaintaining2.aspx");





        }
    }
}