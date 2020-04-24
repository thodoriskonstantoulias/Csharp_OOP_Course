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
            task2.Wait(); // All tasks wait for this one to finish to start

            Task<int> task3 = new Task<int>(Add);
            task3.Start();
            Console.WriteLine(task3.Result);

            Task.WaitAll(task,task2,task3); //Waits for all the tasks to finish and then continues
            Console.WriteLine("End of program");
        }

        public static void PlayingWithTasks()
        {
            Method1();
            Method2();
        }

        public static Task Method1()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Method 1 Task");
            });
        }

        public static Task Method2()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Method 2 Task");
            });
        }

        public static void SayHi(object name)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Hi " + name);          
        }

        public static int Add()
        {
            return 1;
        }
    }
}
