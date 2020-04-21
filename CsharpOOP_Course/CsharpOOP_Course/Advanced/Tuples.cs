using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class Tuples
    {
        public static void PlayingWithTuples()
        {
            var empInfo = new Tuple<int, string, string, DateTime, bool>(100, "Ted", "Kos", new DateTime(2000, 01, 01), true);
            Console.WriteLine(empInfo.Item1);
            Console.WriteLine(empInfo.Item2);
            Console.WriteLine(empInfo.Item3);
            Console.WriteLine(empInfo.Item4);
            Console.WriteLine(empInfo.Item5);


            Console.WriteLine("------------");

            //Alternative way to create tuple
            var studentInfo = Tuple.Create(100, "Kostas", "Kos", new DateTime(2000, 01, 01), true);
            Console.WriteLine(studentInfo.Item1);
            Console.WriteLine(studentInfo.Item2);
            Console.WriteLine(studentInfo.Item3);
            Console.WriteLine(studentInfo.Item4);
            Console.WriteLine(studentInfo.Item5);
        }

        public static void PlayingWithNestedTuples()
        {
            var empInfo = new Tuple<int, string, string, DateTime, bool,int,int,Tuple<int,int,int>>
                (100, "Ted", "Kos", new DateTime(2000, 01, 01), true,2,2,Tuple.Create(1,1,1));

            Console.WriteLine(empInfo.Item1);
            Console.WriteLine(empInfo.Rest.Item1);
        }
    }
}
