using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADONETCoreApp
{
    public class TrainerDB
    {
        public List<Trainer> AllTrainers()
        {

            List<Trainer> trainers = new List<Trainer>();

            string connectionString =
                "server=.\\sqlexpress;database=B22ADONETDB;integrated security=true;encrypt=false;";

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Trainer", con); // inline query oR ADHOC query

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Trainer t = new Trainer()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        City = reader["City"].ToString(),
                        Experience = (int)reader["Experience"]
                    };
                    trainers.Add(t);

                }
            }
            else
            {
                trainers = null;
            }
            con.Close();
            return trainers;

        }


        public bool DeleteTrainer(int id)
        {
            string connectionString =
                "server=.\\sqlexpress;database=B22ADONETDB;integrated security=true;encrypt=false;";

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("uspDeleteTrainer", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            SqlParameter status = new SqlParameter()
            {
                ParameterName = "@Status",
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Output,
            };

            cmd.Parameters.Add(status);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            return (bool)status.Value;
        }


        public bool CreateTrainer(Trainer trainer, out int rollNumber)
        {
            string connectionString =
                "server=.\\sqlexpress;database=B22ADONETDB;integrated security=true;encrypt=false;";

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("uspCreateTrainer", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", trainer.Name);
            cmd.Parameters.AddWithValue("@City", trainer.City);
            cmd.Parameters.AddWithValue("@Experience", trainer.Experience);

            SqlParameter rn = new SqlParameter()
            {
                ParameterName = "@RollNumber",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(rn);

            SqlParameter status = new SqlParameter()
            {
                ParameterName = "@Status",
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(status);

            con.Open();

            cmd.ExecuteNonQuery();

            rollNumber = (int)rn.Value;

            return (bool)status.Value;
        }

    }
}
