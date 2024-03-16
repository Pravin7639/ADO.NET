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
    public partial class StudentDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connectionString =
               ConfigurationManager.ConnectionStrings["Pravin45"].ConnectionString;

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from student", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            gvStudents.DataSource = reader;
            gvStudents.DataBind();

            con.Close();

        }

        private void LoadStudents()
        {


        }
    
    
    
    }
}