using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.OOP
{
    public class Exercises_OOP
    {
        public static void InheritanceExample()
        {
            //We can see that we can access all members and functions(except of private members) of the inherited class
            FourWheels fourWheels = new FourWheels();
            fourWheels.Drive();
            fourWheels.Start();
        }
    }

    public class Vehicle
    {       
    }

    public class WheeledVehicles : Vehicle
    {
        public string Color { get; set; }
        
        public string Fuel { get; set; }

        public void Start()
        {
            Console.WriteLine("Start vehicle");
        }
        public void Stop()
        {
            Console.WriteLine("Stop vehicle");
        }       
    }

    public class FourWheels : WheeledVehicles
    {
        public string Manufacturer { get; set; }
        public int MaxSpeed { get; set; }
        public void Drive()
        {
            Console.WriteLine("Drive vehicle");
        }
    }
}
