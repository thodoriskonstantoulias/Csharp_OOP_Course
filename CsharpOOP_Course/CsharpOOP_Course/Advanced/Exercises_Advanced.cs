using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class Exercises_Advanced
    {
        public static void FileCreationExercise()
        {
            string language = String.Empty;
            int count = Enum.GetNames(typeof(Languages)).Length;
            for (int i = 0; i < count; i++)
            {
                language = Enum.GetValues(typeof(Languages)).GetValue(i).ToString();
                Directory.CreateDirectory(@"D:\Users\TED\Desktop\test_course\" + language);
                using (StreamWriter sw = new StreamWriter(@"D:\Users\TED\Desktop\test_course\" + language + @"\log.txt"))
                {
                    sw.WriteLine("File no " + (i + 1) + " created on " + DateTime.Now);
                }
            }
            Console.WriteLine("Program ended");
           
        }

        public static void NonGenericCollectionExercise()
        {
            Animals dog = new Animals();
            dog.Name = "dog";
            Animals cat = new Animals();
            cat.Name = "cat";
            Animals lion = new Animals();
            lion.Name = "lion";
            Trainers ted = new Trainers();
            ted.TrainerName = "Ted";
            
            ArrayList array = new ArrayList();
            array.Add(dog);
            array.Add(cat);
            array.Add(lion);
            foreach (var item in array)
            {
                ((Animals)item).SayHi();
            }

            Console.WriteLine("---------------");

            array.Add(ted);
            foreach (var item in array)
            {
                if (item is Animals)
                {
                    ((Animals)item).SayHi();
                }
                else if (item is Trainers)
                {
                    ((Trainers)item).SayHi();
                }
                
            }

        }

        public static void GenericClassesExercise()
        {
            Movies<double, DateTime> movies1 = new Movies<double, DateTime>();
            movies1.Name = "Lord of the Rings";
            movies1.Rate = 15.5d;
            movies1.ReleaseDate = new DateTime(2000, 01, 01);

            Movies<float, int> movies2 = new Movies<float, int>();
            movies2.Name = "Seven";
            movies2.Rate = 15.3f;
            movies2.ReleaseDate = 2007;

            List<Movies<double, DateTime>> list1 = new List<Movies<double, DateTime>>();
            list1.Add(movies1);
            List<Movies<float, int>> list2 = new List<Movies<float, int>>();
            list2.Add(movies2);

            Console.WriteLine("List 1");
            foreach (var item in list1)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Rate);
                Console.WriteLine(item.ReleaseDate);
            }

            Console.WriteLine("List 2");
            foreach (var item in list2)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Rate);
                Console.WriteLine(item.ReleaseDate);
            }
        }
    }

    class Movies<T1,T2>
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public T1 Rate { get; set; }
        public T2 ReleaseDate { get; set; }
    }

    struct Animals
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi()
        {
            Console.WriteLine(name + " says Hi!!!");
        }

    }

    struct Trainers
    {
        private string trainerName;

        public string TrainerName
        {
            get { return trainerName; }
            set { trainerName = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("The trainer " + trainerName + " says Hi!!!");
        }
    }

    enum Languages
    {
        English,
        German,
        Arabic
    }
}
