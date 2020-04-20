
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class ListGeneric
    {
        public static void PlayingWithLists()
        {
            List<string> list = new List<string>();

            Console.WriteLine("Adding to list");
            list.Add("ted");
            list.Add("kostas");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");

            Console.WriteLine("Counting list");
            Console.WriteLine(list.Count);
            Console.WriteLine("--------------");

            Console.WriteLine("Sorting list");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
        }
    }
}
