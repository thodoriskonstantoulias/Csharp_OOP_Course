using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class SortedListNonGeneric
    {
        public static void PlayingWithSortedLists()
        {
            SortedList sortedList = new SortedList(); 

            Console.WriteLine("Adding values to sorted list");
            sortedList.Add(1, "ted");
            sortedList.Add(3, false);
            sortedList.Add(2, "kostas");

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.WriteLine("------------------");

            Console.WriteLine("Count of sorted list");
            Console.WriteLine(sortedList.Count);
            Console.WriteLine("------------------");

            Console.WriteLine("Remove from sorted list");
            sortedList.Remove(1);
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine("------------------");

            Console.WriteLine("Contain key sorted list");
            Console.WriteLine(sortedList.Contains(1));
            Console.WriteLine("------------------");

            Console.WriteLine("Copy sorted list to array list");
            ArrayList array = new ArrayList(sortedList.Values);
            foreach (var item in array)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("------------------");
        }
    }
}
