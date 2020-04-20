using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class DictionaryGeneric
    {
        public static void PlayingWithDictionaries()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            Console.WriteLine("Adding to dictionary");
            dict.Add("France", "Paris");
            dict.Add("Spain", "Barcelona");
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine("------------------");

            Console.WriteLine("Counting items in dictionary");
            Console.WriteLine(dict.Count);
            Console.WriteLine("------------------");

            Console.WriteLine("Getting items in dictionary");
            Console.WriteLine(dict.TryGetValue("France", out string value));
            Console.WriteLine("------------------");
        }
    }
}
