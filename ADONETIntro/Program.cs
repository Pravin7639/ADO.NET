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

            TrainerDB db = new TrainerDB();
            List<Trainer> trainers = db.AllTrainers();

            Console.WriteLine("*** All Trainers from DataBase ***");
            foreach (var item in trainers)
            {
                Console.WriteLine($"Id : {item.Id} Name : {item.Name} " +
                    $"City : {item.City} Experience : {item.Experience}");
            }






            Console.ReadLine();
        }
    }
}
