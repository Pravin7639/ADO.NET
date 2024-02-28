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

        //        public List<Trainer> AllTrainers()
        //        {

        //            List<Trainer> trainers = new List<Trainer>();
        //            string connectionString = "server=.\\sqlexpress;database=B22ADONETDB;integrated security =true";

        //            //SqlConnection con = new SqlConnection(); // it requires System.Data.SqlClient nameSpace
        //            //con.ConnectionString = connectionString;

        //            SqlConnection con = new SqlConnection(connectionString);
        //            con.Open();

        //           // for creating command class
        //            string cmdText = "select Id, Name, City, Experience from Trainer";
        //        SqlCommand cmd = new SqlCommand(cmdText, con);

        //        con.Open();
        //            SqlDataReader reader = cmd.ExecuteReader();

        //            if (reader.HasRows) //  HasRows returns true or false
        //            {
        //                while (reader.Read())  // if there is any row it will return true else return false
        //                {
        //                    Trainer t = new Trainer();
        //        t.Id = (int) reader["Id"];
        //        t.Name = reader["Name"].ToString();
        //        t.City = reader["City"].ToString();
        //        t.Experience = (int) reader["Experience"];
        //        trainers.Add(t);

        //                }


        //}

        //con.Close();

        //return trainers;


        //        }
        #endregion Selecting Records from 1 Table


        #region  selecting records from 2 Tables
        public void AllTrainers(out List<Trainer> trainers, out List<Student> students)
        {
            trainers = new List<Trainer>();
            students = new List<Student>();


            string ConnectionString = "server=.\\sqlexpress;database=B22ADONETDB;" +
                "integrated security=true";

            SqlConnection con = new SqlConnection(ConnectionString);
            //con.Open();

            string cmdText = "select  Id, Name, City, Experience from Trainer;select RollNumber, Name, Gender, TrainerId from Student";
            SqlCommand cmd = new SqlCommand(cmdText, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

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


            reader.NextResult();   // it will point to next result set

            while (reader.Read())
            {
                Student s = new Student()
                {
                    RollNumber = (int)reader["RollNumber"],
                    Name = reader["Name"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    TrainerId = (int)reader["TrainerId"]

                };
                students.Add(s);
            }

            con.Close();
        }
        #endregion  selecting records from 2 Tables










    }
}
