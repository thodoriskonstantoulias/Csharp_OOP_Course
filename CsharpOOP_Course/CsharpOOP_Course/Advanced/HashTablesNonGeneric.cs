using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class HashTablesNonGeneric
    {
        public static void PlayingWithHashTables()
        {
            Hashtable hash = new Hashtable();

            Console.WriteLine("Adding to hash");
            hash.Add("Microsoft", "USA");
            hash.Add("Flag", true);
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine("Key : " + item.Key + " -- Value : " + item.Value);
            }

            Console.WriteLine("-----------------");

            Console.WriteLine("Getting the count");
            Console.WriteLine(hash.Count);
            Console.WriteLine("-----------------");

            Console.WriteLine("Removing a value");
            hash.Remove("Flag");
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine("Key : " + item.Key + " -- Value : " + item.Value);
            }
            Console.WriteLine("-----------------");

            Console.WriteLine("Containing a value");
            Console.WriteLine(hash.Contains("Microsoft"));
            Console.WriteLine("-----------------");

            Console.WriteLine("Copy hash values to ArrayList");
            ArrayList array = new ArrayList(hash.Values);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");

        }
    }
}
