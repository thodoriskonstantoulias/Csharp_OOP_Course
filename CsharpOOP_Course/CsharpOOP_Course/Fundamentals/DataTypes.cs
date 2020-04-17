using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Fundamentals
{
    public class DataTypes
    {
        static int x = 0;
        static float f = 1.5f;

        public static void DifferenceInIntConversion()
        {
            Console.WriteLine("Value of float is " + f);
            x = Convert.ToInt32(f);
            Console.WriteLine("ConvertToInt32 method value : " + x);

            x = (int)f;
            Console.WriteLine("Type casting method value : " + x);
        }
    }
}
