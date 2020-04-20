using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class ArrayListNonGeneric
    {
        public static void PlayingWithArrayLists()
        {
            ArrayList array = new ArrayList();

            array.Add("ted");
            array.Add("kostas");
            array.Add(5);
            array.Add(false);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");

            array.Insert(1, "maria");
            Console.WriteLine("After insertion of new object");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");

            Console.WriteLine("Showing capacity");
            Console.WriteLine(array.Capacity);
            Console.WriteLine("----------------");

            Console.WriteLine("Showing count");
            Console.WriteLine(array.Count);
            Console.WriteLine("----------------");

            Console.WriteLine("Reversing elements");
            array.Reverse();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");

            Console.WriteLine("Removing elements");
            array.Remove("ted");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");

            Console.WriteLine("Contains question");
            Console.WriteLine(array.Contains("maria"));
            Console.WriteLine("----------------");

            Console.WriteLine("Copying list to another list");
            ArrayList array2 = array.GetRange(0, 2);
            Console.WriteLine("New list");
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
        }
    }
}
