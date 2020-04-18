using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Fundamentals
{
    public class Exercises
    {
        public static void EvenOrOdd(int number)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine("Number " + number + " is even");
            }
            else
            {
                Console.WriteLine("Number " + number + " is odd");
            }
        }

        public static void FriendlyConversation()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name + ". How old are you" );
            int age;
            int.TryParse(Console.ReadLine(), out age);
            int myage = DateTime.Now.Year - new DateTime(1991, 01, 01).Year;

            Console.WriteLine("You are " + age + ". I was born in 1991 so that makes me " + myage);
        }

        public static void FindTheDay()
        {
            Console.WriteLine("What is your day?");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your month?");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your year?");
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);

            Console.WriteLine("This day should be " + date.DayOfWeek);
        }
    }
}
