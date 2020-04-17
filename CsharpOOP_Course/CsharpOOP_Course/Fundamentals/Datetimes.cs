using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Course.Fundamentals
{
    public class Datetimes
    {
        public static void DatetimesInGeneral()
        {
            DateTime date = new DateTime(2020, 01, 01);
            Console.WriteLine("An example of date is " + date);

            DateTime today = DateTime.Now;
            Console.WriteLine("Today is " + today);
        }

        public static void FormatString()
        {
            DateTime today = DateTime.Now;
            string formattedDate = string.Format("Date is {0:yyyy}", today);
            Console.WriteLine("Today (formatted) " + formattedDate);

            string fullMonth = string.Format("Date is {0:yyyy MMMM d}", today);
            Console.WriteLine("Today (formatted with full month) " + fullMonth);

            string formatWithDashes = string.Format("Date is {0:d-MM-yyyy HH:mm:ss}", today);
            Console.WriteLine("Today (formatted with dashes) " + formatWithDashes);

            string formatWithWords = string.Format("Date is {0:dddd 'of month' MMMM 'year' yyyy}", today);
            Console.WriteLine("Today (formatted with full words) " + formatWithWords);
        }
    }
}
