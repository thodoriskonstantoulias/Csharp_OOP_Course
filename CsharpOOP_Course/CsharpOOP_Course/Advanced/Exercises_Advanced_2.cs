using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public delegate void DisplayDelegate(Dictionary<int, string> dict);
    public delegate void CalcDelegate(int a, int b);
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

        public static void ExtensionExercise2()
        {
            string str = "test hello t there";            
            Console.WriteLine(str.Capitalize());
        }
         
        public static void DelegatesExercise()
        {
            DisplayDelegate del = new DisplayDelegate(DisplayDictInfo);
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "ted");
            dict.Add(2, "kostas");
            del(dict);
        }

        public static void DelegatesExercise2()
        {
            CalcDelegate calDel = new CalcDelegate(Add);
            calDel += Subtract;
            calDel += Mult;
            calDel(2, 4);
        }

        public static void DisplayDictInfo(Dictionary<int,string> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        public static void Add(int a , int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Mult(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }

    public static class Extensions
    {
        public static void DisplayDate(this DateTime date)
        {
            Console.WriteLine(string.Format("{0:dddd d \nMMMM yyyy }",date));
        }

        public static string Capitalize(this string word)
        {
            bool blankFound = false;
            char[] ch = word.Trim().ToLower().ToCharArray();

            ch[0] = (char)((int)ch[0] - 32);

            for (int i = 1; i < ch.Length; i++)
            {
                if (blankFound && ch[i] != ' ')
                {
                    ch[i] = (char)((int)ch[i] - 32);
                    blankFound = false;
                }
                if (ch[i] == ' ') blankFound = true;
            }
            return new string(ch);
        }
    }
}
