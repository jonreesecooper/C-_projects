using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodaysDate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime todaysDate = DateTime.Now;
            Console.WriteLine("Today's date is {0}", todaysDate);
            Console.WriteLine("Please enter a number:");
            double userInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("In {0} hours it will be {1}", userInput, todaysDate.AddHours(userInput));
            Console.ReadLine();
        }
    }
}
