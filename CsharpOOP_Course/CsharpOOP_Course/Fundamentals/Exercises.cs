﻿using System;
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

        public static void ShowEvenNumbers()
        {
            for (int i = 0; i <= 100; i+= 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void ShowTriangleShapeWithZeros()
        {
            for (int i = 1; i <= 10 ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
        }

        public static void ShowUpsideTriangle()
        {
            for (int i = 16; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
        }

        public static void RollDiceGame()
        {
            Console.WriteLine("Roll dice (Yes,No)");
            string ans = Console.ReadLine().ToLower();
            Random rand = new Random();
            
            while( ans == "yes" )
            {
                Console.WriteLine($"New dice number is {rand.Next(1,7)}");
                Console.WriteLine("Roll dice (Yes,No)");
                ans = Console.ReadLine().ToLower();
            }
        }

    }
}
