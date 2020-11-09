using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            try
            {
                var userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput < 1)
                {
                    throw new ArgumentException();
                }
                var myDate = DateTime.Now.Year;
                var birthYear = myDate - userInput;
                Console.WriteLine("You were born in the year {0}", birthYear);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You did not enter a positive whole number");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("The age you entered was input incorrectly.");
                Console.ReadLine();
            }
        }
    }
}
