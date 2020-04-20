using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class QueueNonGeneric
    {
        public static void PlayingWithQueues()
        {
            Queue queue = new Queue();

            Console.WriteLine("Adding to queue");
            queue.Enqueue("kostas");
            queue.Enqueue(false);
            queue.Enqueue(3);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");

            Console.WriteLine("Dequeue from queue");
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
        }
    }
}
