using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class BitArrayNonGeneric
    {
        public static void PlayingWithBitArrays()
        {
            bool[] boolArray = new bool[4];
            boolArray[0] = false;
            boolArray[1] = false;
            boolArray[2] = true;
            boolArray[3] = false;

            BitArray array1 = new BitArray(4);
            BitArray array2 = new BitArray(boolArray);

            Console.WriteLine("Setting values in BitArray");
            array1.Set(0, false);
            array1.Set(1, false);
            array1.Set(2, true);
            array1.Set(3, true);

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Using AND with bit arrays");
            BitArray result = new BitArray(4);
            result = array1.And(array2);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
