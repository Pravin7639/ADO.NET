using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ADODOTNetWebApp
{
    public partial class TrainerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string cs = ConfigurationManager.ConnectionStrings["Pravin45"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("select * from trainer", con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            gvTrainers.DataSource = reader;
            gvTrainers.DataBind();

            lblMessage.Text = "Trainers Loaded From Database";

            con.Close();

        }
    }
}