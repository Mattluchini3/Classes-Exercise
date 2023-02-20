using System;
using System.Reflection;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

        }
            public class Car
         {
            public int Age = 2022;
            public string Make { get; set; }
            public string Model { get; set; }

            public void HowOldCarIs()
            {
                Console.WriteLine($"Year of the Jeep Wrangler is {Age}");
            }

            Car c2 = new Car()
            {
                Make = "Jeep",
                Model = "Wrangler"
            };
        }
    }
}
        
    //Create a Make property of type string that is public
    //Create a Model property of type string that is public
    //Create a Year property of type int that is publiC 

    
