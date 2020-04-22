using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public delegate void DisplayDelegate(Dictionary<int, string> dict);
    public class Exercises_Advanced_2
    {       
        public static void RecursionExercise()
        {
            string path = @"D:\Users\TED\Desktop\test_course";
            Console.WriteLine(path);
            DisplayFolder(path, 0);
        }

        public static void DisplayFolder(string path, int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{new string(' ',indent)} {Path.GetFileName(folder)}");
                DisplayFolder(folder, indent + 2);
            }
        }

        public static void ParamsExercise()
        {
            DisplayItems("ted", "kostas", "maria");
        }

        public static void DisplayItems<T>(params T[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public static void ExtensionMethodExercise()
        {
            DateTime date = new DateTime(2020, 04, 06);
            date.DisplayDate();
        }

        public static void DelegatesExercise()
        {
            DisplayDelegate del = new DisplayDelegate(DisplayDictInfo);
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "ted");
            dict.Add(2, "kostas");
            del(dict);
        }

        public static void DisplayDictInfo(Dictionary<int,string> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }

    public static class Extensions
    {
        public static void DisplayDate(this DateTime date)
        {
            Console.WriteLine(string.Format("{0:dddd d \nMMMM yyyy }",date));
        }
    }
}
