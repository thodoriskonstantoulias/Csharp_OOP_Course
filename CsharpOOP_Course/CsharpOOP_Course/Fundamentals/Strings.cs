using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Fundamentals
{
    public class Strings
    {
        public static void StringManipulation()
        {
            string text = "Some text to play";
            Console.WriteLine("The word is : " + text);
            Console.WriteLine("The first character of the string is " + text[0]);

            Console.WriteLine("Upper case string is : " + text.ToUpper());
            Console.WriteLine("Lower case string is : " + text.ToLower());

            Console.WriteLine("Length of the string is : " + text.Length);

            Console.WriteLine("Replace o with a in the string : " + text.Replace('o','a'));

            string trimmedText = "   some text   ";
            Console.WriteLine("The trimmed version is : " + trimmedText.Trim());
        }
    }
}
