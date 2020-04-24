using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpOOP_Course.Advanced
{
    public class Exercises_Advanced_4
    {
        static ConcurrentStack<int> stack;
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

        public static void PlayingWithConcurrentCollections()
        {
            stack = new ConcurrentStack<int>();
            FillStack1();
            FillStack2();
            GetStack1();
            GetStack2();
        }

        public static async Task FillStack1()
        {
            await Task.Run(() => 
            {
                for (int i = 1; i < 11; i++)
                {
                    stack.Push(i);
                }
            });
        }

        public static async Task FillStack2()
        {
            await Task.Run(() =>
            {
                for (int i = 11; i < 21; i++)
                {
                    stack.Push(i);
                }
            });
        }

        public static async Task GetStack1()
        {
            await Task.Run(() => 
            {
                int count = 0;
                foreach (var item in stack)
                {
                    stack.TryPop(out int poppedItem);
                    if (poppedItem != 0)
                    {
                        Console.WriteLine("Now Thread 3 is accessing " + poppedItem);
                        count++;
                    }
                    
                }
                Console.WriteLine("Thread 3 accessed " + count);
            });            
        }
        public static async Task GetStack2()
        {
            await Task.Run(() => 
            {
                int count = 0;
                foreach (var item in stack)
                {
                    stack.TryPop(out int poppedItem);
                    if (poppedItem != 0)
                    {
                        Console.WriteLine("Now Thread 4 is accessing " + poppedItem);
                        count++;
                    }                   
                }
                Console.WriteLine("Thread 4 accessed " + count);
            });           
        }
    }
}
