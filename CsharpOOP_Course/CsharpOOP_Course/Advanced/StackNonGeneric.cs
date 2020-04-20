using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Advanced
{
    public class StackNonGeneric
    {
        public static void PlayingWithStacks()
        {
            Stack stack = new Stack();
            Console.WriteLine("Adding to stack");
            stack.Push("kostas");
            stack.Push(false);
            stack.Push(3);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");

            Console.WriteLine("Popping from stack");
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
        }
    }
}
