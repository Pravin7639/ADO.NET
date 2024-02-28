using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETIntro
{
    public class TrainerDB
    {
        //Select All Trainers

        #region Selecting Records from 1 Table

        public List<Trainer> AllTrainers()
        {

            List<Trainer> trainers = new List<Trainer>();
            string connectionString = "server=.\\sqlexpress;database=B22ADONETDB;integrated security =true";

            //SqlConnection con = new SqlConnection(); // it requires System.Data.SqlClient nameSpace
            //con.ConnectionString = connectionString;

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

           // for creating command class
            string cmdText = "select Id, Name, City, Experience from Trainer";
        SqlCommand cmd = new SqlCommand(cmdText, con);

        con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows) //  HasRows returns true or false
            {
                while (reader.Read())  // if there is any row it will return true else return false
                {
                    Trainer t = new Trainer();
        t.Id = (int) reader["Id"];
        t.Name = reader["Name"].ToString();
        t.City = reader["City"].ToString();
        t.Experience = (int) reader["Experience"];
        trainers.Add(t);

                }


}

con.Close();

return trainers;


        }
        #endregion Selecting Records from 1 Table




    }
}
