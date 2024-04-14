using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_PRACTICE
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Fetching student data from DataBase

            //StudentDB db = new StudentDB();
            //List<Student> s = db.AllStudent();

            //Console.WriteLine("All Students From Database");
            //foreach (var item in s)
            //{
            //    Console.WriteLine($"RollNumber : {item.RollNumber} Name : {item.Name} " +
            //        $"Gender : {item.Gender} TrainerId : {item.TrainerId} ");
            //}

            #endregion Fetching student AND Trainer data from DataBase


            #region Fetching student AND Trainer data from DataBase


            //StudentDB db = new StudentDB();

            //List<Student> students;
            //List<Trainer> trainers;

            //db.AllStudentTrainer(out students, out trainers);

            //Console.WriteLine("All Students From DataBase");
            //foreach (var item in students)
            //{
            //    Console.WriteLine($"RollNumber : {item.RollNumber} Name : {item.Name} Gender : {item.Gender} " +
            //        $"TrainerId : {item.TrainerId} ");
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //Console.WriteLine("All Trainers From DataBase");
            //foreach (var item in trainers)
            //{
            //    Console.WriteLine($"Id : {item.Id} Name : {item.Name} City : {item.City} " +
            //        $"Experince : {item.Experience} ");
            //}


            #endregion Fetching student AND Trainer data from DataBase


            #region GetStudentByRollNumber

            //StudentDB db = new StudentDB();

            //Console.WriteLine("Please Enter Student RollNumber");
            //int RollNumber = int.Parse(Console.ReadLine());

            //Student s = db.GetStudentByRollNumber(RollNumber);

            //if (s != null)
            //{
            //    Console.WriteLine($"RollNumber : {s.RollNumber} Name : {s.Name} Gender : {s.Gender} " +
            //        $"TrainerId : {s.TrainerId} ");
            //}
            //else
            //{
            //    Console.WriteLine($"Student with RollNumber {RollNumber} is not Found");
            //}

            #endregion GetStudentByRollNumber


            #region SQL Injection

            //Console.WriteLine("Please Enter A RollNumber To Search Stuent");

            //string rn = Console.ReadLine();

            //string ConnectionString = "server=.\\sqlexpress;database=B22ADONETDB;integrated security=true;";

            //SqlConnection con = new SqlConnection(ConnectionString);

            //string cmdText =$"Select * from Student where RollNumber= {rn}";

            //SqlCommand cmd = new SqlCommand(cmdText, con);
            //con.Open();

            //SqlDataReader reader = cmd.ExecuteReader();

            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        Student s = new Student()
            //        {
            //            RollNumber= (int)reader["RollNumber"],
            //            Name=reader["Name"].ToString(),
            //            Gender=reader["Gender"].ToString(),
            //            TrainerId=(int) reader["TrainerId"]
            //        };

            //        Console.WriteLine($"RollNumber : {s.RollNumber} Name : {s.Name} Gender : {s.Gender} " +
            //            $"TrainerId : {s.TrainerId} ");

            //        break;

            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Student With RollNumber {rn} is Not Found");
            //}



            #endregion SQL Injection



            //Console.WriteLine("Create A New Student");
            //Console.WriteLine("Please enter Name ");








            Console.ReadLine();
        }
    }
}
