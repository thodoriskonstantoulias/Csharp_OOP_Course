using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class SortedListGeneric
    {
        public static void PlayingWithSortedLists()
        {
            SortedList<int, string> list = new SortedList<int, string>();

            Console.WriteLine("Adding to sorted list");
            list.Add(2, "ted");
            list.Add(1, "kostas");
            foreach (var item in list)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine("--------------");

            Console.WriteLine("Try getting value from sorted list");
            list.TryGetValue(2, out string value);
            Console.WriteLine(value);
            Console.WriteLine("--------------");

            Console.WriteLine("Contains from sorted list");
            Console.WriteLine(list.ContainsKey(3));
            Console.WriteLine("--------------");
        }
    }
}
