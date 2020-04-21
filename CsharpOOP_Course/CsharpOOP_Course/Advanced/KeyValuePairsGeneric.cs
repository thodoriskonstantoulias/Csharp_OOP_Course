using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class KeyValuePairsGeneric
    {
        public static void PlayingWithKeyValuePairs()
        {
            Console.WriteLine("Add to list of key value pairs");
            var list = new List<KeyValuePair<int, string>>();
            list.Add(new KeyValuePair<int, string>(1, "ted"));
            list.Add(new KeyValuePair<int, string>(2, "kostas"));

            foreach (var item in list)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine("--------------");

            Console.WriteLine("Using key value pair in real scenario");
            Console.WriteLine(GetFirstAndLastName());
        }

        public static KeyValuePair<string, string> GetFirstAndLastName()
        {
            string firstName = "ted";
            string lastName = "kos";
            return new KeyValuePair<string, string>(firstName,lastName);
        }
    }
}
