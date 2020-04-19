using CsharpOOP_Course.OOP.Enums;
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

        public static void PolymorphismExample()
        {
            Car general = new Car(5000,"White", 150);
            general.DisplayInfo();
            Car mer = new Mercedes(10000,"Black",250);
            mer.DisplayInfo();
        }

        public static void OOP_Big_Example()
        {
            Country countryFirst = new Country("Greece", "Athens");
            Country countrySecond = new Country("France", "Paris");

            CountryLanguages countryLanguages = new CountryLanguages();
            countryLanguages.FirstLanguage = Languages.English;
            countryLanguages.SecondLanguage = Languages.Italian;

            countryFirst.CountryLanguages = countryLanguages;
            countryFirst.PlanetName = "earth";
            countryFirst.Continents = Continents.Europe;
            countryFirst.Currency = Currencies.Euro;

            countryFirst.SayHi();
            countryFirst.SayHi(countryFirst);
        }
    }

    public class Car
    {
        public Car(decimal price, string color, int maxSp)
        {
            Price = price;
            Color = color;
            maxSpeed = maxSp;
        }
        public decimal Price { get; set; }
        public string Color { get; set; }
        protected int maxSpeed { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"price is {Price}, and color is {Color} and max speed is {maxSpeed} for base class");
        }
    }

    public class Mercedes : Car
    {
        public Mercedes(decimal price, string color, int maxSp) : base(price, color, maxSp)
        {
            
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"price is {Price}, and color is {Color} and max speed is {maxSpeed} for child class");
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
