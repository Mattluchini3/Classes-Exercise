using System;
using System.Reflection;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Jeep";
            car1.Model = "Wrangler";
            car1.Year = 2015;

            Console.WriteLine($"The make of the car: {car1.Make}.");
            Console.WriteLine($"The model of the car: {car1.Model}.");
            Console.WriteLine($"The year of the car: {car1.Year}.");
        }
    }
}


//Create a Make property of type string that is public
//Create a Model property of type string that is public
//Create a Year property of type int that is publiC 


