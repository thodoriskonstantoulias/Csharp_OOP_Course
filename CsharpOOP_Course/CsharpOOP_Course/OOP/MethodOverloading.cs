using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.OOP
{
    public class MethodOverloading
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine($"The sum of {a} + {b} = {a + b}");
        }

        public static void Add(int a, int b, int c)
        {
            Console.WriteLine($"The sum of {a} + {b} + {c} = {a + b + c}");
        }

        public static void Add(double a, double b)
        {
            Console.WriteLine($"The sum of {a} + {b} = {a + b}");
        }

        public static void Add(double a, double b, double c)
        {
            Console.WriteLine($"The sum of {a} + {b} + {c} = {a + b + c}");
        }
    }
}
