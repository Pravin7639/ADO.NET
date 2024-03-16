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
    public partial class CreateStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTrainers();
            }
        }

        protected void LoadTrainers()
        {
          
            string connectionString =
               ConfigurationManager.ConnectionStrings["Pravin45"].ConnectionString;

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Trainer", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            ddlTrainers.DataValueField = "Id";
            ddlTrainers.DataTextField = "Name";


            ddlTrainers.DataSource = reader;
            ddlTrainers.DataBind();

            ddlTrainers.Items.Insert(0, new ListItem() { Value = "-1", Text = "-- Select Trainer --" });


            con.Close();

        }


        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtName.Text;
                //string Gender = txtGender.Text;
                var items = rblGender.Items.Cast<ListItem>();
                string gender = items.FirstOrDefault(i => i.Selected == true)?.Value;

                //string TrainerId = txtTrainer.Text;

                int trainerId = int.Parse(ddlTrainers.SelectedValue);


                // ado.net code to insert student in database

                string connectionString = ConfigurationManager.ConnectionStrings["Pravin45"].ConnectionString;

                SqlConnection con = new SqlConnection(connectionString);

                string cmdText = $"Insert into Student values ('{Name}' , '{gender}', {trainerId} ) ";

                SqlCommand cmd = new SqlCommand(cmdText, con);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Response.Redirect("StudentDashboard.aspx");
                }
                else
                {
                    lblMessage.Text = "Error in creating student";
                }
            }

            catch
            {
                lblMessage.Text = "Error in creating student";
            }

        }
    }
}