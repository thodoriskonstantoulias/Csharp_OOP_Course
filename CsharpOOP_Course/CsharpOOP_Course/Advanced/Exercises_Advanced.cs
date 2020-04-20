using System;
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
    }

    enum Languages
    {
        English,
        German,
        Arabic
    }
}
