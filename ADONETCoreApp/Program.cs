using System;
using Microsoft.Data.SqlClient;
using ADONETCoreApp;

Console.WriteLine("*** ALL TRAINERS ***");

TrainerDB db = new TrainerDB();
var trainers = db.AllTrainers();

foreach (var item in trainers)
{
    Console.WriteLine($"Id : {item.Id} Name : {item.Name} City : {item.City}" +
        $" Experience : {item.Experience}");
}


Console.WriteLine("Create A New Trainer");
Console.WriteLine("Please enter name");
string name = Console.ReadLine();
Console.WriteLine("Please enter city");
string city = Console.ReadLine();
Console.WriteLine("Please enter experience");
int experience = int.Parse(Console.ReadLine());

Trainer t = new Trainer() { Name = name, City = city, Experience = experience };

int rn;
if (db.CreateTrainer(t, out rn))
{
    Console.WriteLine($"Trainer Inserted Successfully. Trainer Id is {rn}");
}
else
{
    Console.WriteLine("Failed to insert new trainer");
}



Console.WriteLine("Enter trainer id to delete");
int id = int.Parse(Console.ReadLine());

bool status = db.DeleteTrainer(id);
if (status)
{
    Console.WriteLine($"Trainer with Id {id} Deleted Successfully.");
}
else
{
    Console.WriteLine($"Trainer with Id {id} Delete Failed.");
}


Console.ReadLine();


