using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
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
    }
}
