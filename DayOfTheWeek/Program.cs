using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current a day of the week.");
            string dayEntered = Console.ReadLine();
            try
            {
                WeekDay weekday = (WeekDay)Enum.Parse(typeof(WeekDay), dayEntered);
                Console.WriteLine("The current day of the week is {0}", weekday);
            }
            catch
            {
                Console.WriteLine("Please enter the actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}
