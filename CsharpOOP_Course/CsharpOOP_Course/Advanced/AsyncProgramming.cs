using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpOOP_Course.Advanced
{
    public class AsyncProgramming
    {
        public static void PlayingWithAsyncProg()
        {
            Task task = new Task(new Action<object>(SayHi),"Ted");
            task.Start();

            Task task2 = new Task(() => Console.WriteLine("Hello from Task 2"));
            task2.Start();
        }

        public static void SayHi(object name)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Hi " + name);          
        }
    }
}
