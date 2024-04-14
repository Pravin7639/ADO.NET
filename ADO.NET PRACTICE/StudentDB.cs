using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_PRACTICE
{
    public class StudentDB
    {

        #region Fetching student data from DataBase

        //public List<Student> AllStudent()
        //{
        //    List<Student> students = new List<Student>();

        //string ConnectionString = "server=.\\sqlexpress;database=B22ADONETDB;integrated security=true";

        //SqlConnection con = new SqlConnection(ConnectionString);

        //    string cmdText = "Select * from Student";

        //    SqlCommand cmd = new SqlCommand(cmdText, con);

        //    con.Open();

        //    SqlDataReader reader = cmd.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Student s = new Student()
        //            {
        //                RollNumber = (int)reader["RollNumber"],
        //                Name = reader["Name"].ToString(),
        //                Gender = reader["Gender"].ToString(),
        //                TrainerId = (int)reader["TrainerId"]
        //            };
        //            students.Add(s);

        //        }
        //    }

        //    con.Close();
        //    return students;

        //}





        #endregion Fetching student data from DataBase



        #region Fetching student AND Trainer data from DataBase

        //public void AllStudentTrainer(out List<Student> students, out List<Trainer> trainers)
        //{
        //    students = new List<Student>();
        //    trainers = new List<Trainer>();


        //    string connectionString = "server=.\\sqlexpress;database=B22ADONETDB;integrated security=true";

        //    SqlConnection con = new SqlConnection(connectionString);

        //    string cmdText = "Select * from Student; Select * from Trainer";

        //    SqlCommand cmd = new SqlCommand(cmdText, con);

        //    con.Open();

        //    SqlDataReader reader = cmd.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Student s = new Student()
        //            {
        //                RollNumber = (int) reader["RollNumber"],
        //                Name=reader["Name"].ToString(),
        //                Gender=reader["Gender"].ToString(),
        //                TrainerId=(int) reader["TrainerId"]
        //            };
        //            students.Add(s);
        //        }
        //    }
        //    reader.NextResult();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Trainer t = new Trainer()
        //            {
        //                Id = (int)reader["Id"],
        //                Name = reader["Name"].ToString(),
        //               City=reader["City"].ToString(),
        //                Experience = (int) reader["Experience"]
        //            };

        //            trainers.Add(t);
        //        }
        //    }

        //    con.Close();

        //}


        #endregion Fetching student AND Trainer data from DataBase


        #region GetStudentByRollNumber

        //public Student GetStudentByRollNumber(int id)
        //{
        //    Student student = new Student();

        //    string connectionString = "server=.\\sqlexpress;database=B22ADONETDB;integrated security=true";

        //    SqlConnection con = new SqlConnection(connectionString);

        //    string cmdText =$"Select * from Student where RollNumber={id}";

        //    SqlCommand cmd = new SqlCommand(cmdText, con);

        //    con.Open();

        //    SqlDataReader reader = cmd.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        student.RollNumber = (int)reader["RollNumber"];
        //        student.Name = reader["Name"].ToString();
        //        student.Gender = reader["Gender"].ToString();
        //        student.TrainerId = (int)reader["TrainerId"];

        //        break;
        //    }

        //    con.Close();

        //    return student;
        //}
        #endregion GetStudentByRollNumber










    }
}
