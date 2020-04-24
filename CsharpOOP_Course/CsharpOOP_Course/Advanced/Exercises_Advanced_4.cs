using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CsharpOOP_Course.Advanced
{
    public class Exercises_Advanced_4
    {
        public static void ThreadsExercise()
        {
            Thread t1 = new Thread(new ThreadStart(()=> Console.WriteLine("Hello from Thread with lambda expression")));
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(() => 
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hello from second Thread");
                }
            }));
            t2.Start();
        }
    }
}
