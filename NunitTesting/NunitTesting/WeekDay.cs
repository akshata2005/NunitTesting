using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    public class WeekDay
    {
        public static void FindingDay()
        {
            Console.WriteLine("Enter the date :");
            int date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Month :");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Year :");
            int year = Convert.ToInt32(Console.ReadLine());

            string[] weekDays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (date + x + 31 * m0 / 12) % 7;

            Console.WriteLine("The Day of the given date is : " + weekDays[d0]);
        }
    }
}
