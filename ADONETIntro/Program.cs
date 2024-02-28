using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADO.NET Demo ");

            //TrainerDB db = new TrainerDB();
            //List<Trainer> trainers = db.AllTrainers();

            //Console.WriteLine("*** All Trainers from DataBase ***");
            //foreach (var item in trainers)
            //{
            //    Console.WriteLine($"Id : {item.Id} Name : {item.Name} " +
            //        $"City : {item.City} Experience : {item.Experience}");
            //}




            TrainerDB db = new TrainerDB();

            List<Trainer> trainers;
            List<Student> students;
            db.AllTrainers(out trainers, out students);

            Console.WriteLine("*** All Trainers from DataBase ***");
            foreach (var item in trainers)
            {
                Console.WriteLine($"Id : {item.Id} Name : {item.Name} " +
                    $"City : {item.City} Experience : {item.Experience}");
            }


            Console.WriteLine("*** All Students from DataBase ***");
            foreach (var item in students)
            {
                Console.WriteLine($"Id : {item.RollNumber} Name : {item.Name} " +
                    $"City : {item.Gender} Experience : {item.TrainerId}");
            }







            Console.ReadLine();
        }
    }
}
