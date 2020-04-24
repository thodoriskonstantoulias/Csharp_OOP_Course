using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpOOP_Course.Advanced
{
    public class Threads
    {
        public static void PlayingWithThreads()
        {
            Stopwatch watch = new Stopwatch();
            //watch.Start();
            //SayHiSeq();
            //SayHelloSeq();
            //watch.Stop();
            //Console.WriteLine("Miliseconds passed : " + watch.Elapsed.TotalMilliseconds +"ms");

            watch.Start();
            Thread t1 = new Thread(new ThreadStart(SayHiSeq));
            t1.Start();
            Thread t2 = new Thread(new ThreadStart(SayHelloSeq));
            t2.Start();
            watch.Stop();
            Console.WriteLine("Miliseconds thread passed : " + watch.Elapsed.TotalMilliseconds + "ms");
        }
         
        public static void SayHiSeq()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + " Hi!");
            }
        }
        public static void SayHelloSeq()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + " Hello!");
            }
        }
    }
}
