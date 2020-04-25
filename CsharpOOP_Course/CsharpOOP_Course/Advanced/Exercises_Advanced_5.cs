using Newtonsoft.Json;
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

        public static void MultiDimensionsExercise()
        {
            string[,] multi = new string[3, 3] { { "00", "01", "02" }, { "10", "11", "12" }, { "20", "21", "22" } };
            Console.Write("Column 1     ");
            Console.Write("Column 2     ");
            Console.Write("Column 3     ");
            Console.WriteLine();
            Console.Write("--------     ");
            Console.Write("--------     ");
            Console.Write("--------     ");            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Item" + multi[i,j]);
                    Console.Write("       ");
                }
            }
        }

        public static void JaggedArraysExercise()
        {
            int[][] jagged = { new int[] { 1, 2, 3 }, new int[] { 1, 4, 5, 8 }, new int[] { 1, 3, 6, 6, 2 } };
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine("Now accessing array no " + (i+1));
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.WriteLine("Element " + jagged[i][j]); 
                }
            }
        }

        public static void PLayingWittJSONSerializer()
        {
            List<PersonForJson> list = new List<PersonForJson>()
            {
                new PersonForJson{Name = "Ted",Age = 29, Salary = 10300.33},
                new PersonForJson{Name = "Kostas",Age = 39, Salary = 140300.33}
            };

            var json = JsonConvert.SerializeObject(list);
            Console.WriteLine(json);

            var fake = JsonConvert.DeserializeObject<List<FakePersonForJson>>(json);
            foreach (var item in fake)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
    
    public class PersonForJson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }

    public class FakePersonForJson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }
}
