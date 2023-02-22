using System;
using System.Reflection;
using System;
using Classes;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Year of the {c2.Make} {c2.Model} is {c2.Age}");

        }

         Car c2 = new Car()
         {
             Make = "Jeep",
             Model = "Wrangler",
             Age = 2022
         };
    }
}
        
    //Create a Make property of type string that is public
    //Create a Model property of type string that is public
    //Create a Year property of type int that is publiC 

    
