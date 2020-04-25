using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class Exercises_Advanced_5
    {
        public static void ProcessExercise()
        {
            File.WriteAllText(@"D:\Users\TED\Desktop\notepadExercise.txt", "Hello there");

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"D:\Users\TED\Desktop\notepadExercise.txt")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    } 
}
