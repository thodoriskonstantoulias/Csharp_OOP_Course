using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class Exercises_Advanced_3
    {
        public static void LINQExercise()
        {
            List<Person> list = new List<Person>()
            {
                new Person {Age = 29, Name = "Ted", Salary = 10500d},
                new Person {Age = 40, Name = "Kostas", Salary = 45000d},
                new Person {Age = 35, Name = "Maria", Salary = 5545.5d}
            };

            //Method syntax
            var people = list.Where(p => p.Age > 33);
            foreach (var item in people)
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
