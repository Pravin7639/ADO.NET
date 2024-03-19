using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADODOTNetWebApp
{
    public partial class ValidationDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsValid)   // if javaScript code is off on client machine then it can handle 
            {
                string Name = txtName.Text;
                string Age = txtAge.Text;
                string Email = txtEmail.Text;
                string ConfirmEmail = txtConfirmEmail.Text;


                //ADO.NET code to insert data to DataBase

                lblMessage.Text = "Data Submitted Successfully";
            }
            else
            {
                lblMessage.Text = "Correct Page Erros";

            }


        }

        protected void CustomValidator1_ServerValidate(object source, 
            ServerValidateEventArgs args)
        {
            int input;
            int.TryParse(args.Value, out input);

            if (input % 2 == 0)
            {
                args.IsValid = true;
            }

            args.IsValid = false;
        }
    }
}