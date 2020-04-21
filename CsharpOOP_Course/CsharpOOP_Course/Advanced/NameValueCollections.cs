using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class NameValueCollections
    {
        public static void PlayingWithNameValueCollections()
        {
            NameValueCollection nvc = new NameValueCollection();
            Console.WriteLine("Adding to NameValueCollection");
            nvc.Add("England", "London");
            nvc.Add("England", "Bristol");
            nvc.Add("France", "Paris");

            foreach (string item in nvc)
            {
                Console.WriteLine(item);
                Console.WriteLine(nvc[item]);
            }
            Console.WriteLine("--------------");

            Console.WriteLine("Contains in NameValueCollection");
            Console.WriteLine(nvc.HasKeys());
            Console.WriteLine("--------------");
        }
    }
}
