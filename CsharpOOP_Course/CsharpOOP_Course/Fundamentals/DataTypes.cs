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

        public static void MaxDataTypesNumbers()
        {
            Console.WriteLine("The maximum number for int is " + int.MaxValue);
            Console.WriteLine("The maximum number for float is " + float.MaxValue);
            Console.WriteLine("The maximum number for double is " + double.MaxValue);
            Console.WriteLine("The maximum number for decimal is " + decimal.MaxValue);
        }

        public static void CheckPrecision()
        {
            Console.WriteLine("Float : 1/3 = " + 1/3f);
            Console.WriteLine("Double : 1/3 = " + 1 / 3d);
            Console.WriteLine("Decimal : 1/3 = " + 1 / 3m);
        }
    }
}
