using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a whole number:");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may enter a 2nd number, but it is optional:");
            string userInput2 = (Console.ReadLine());
            if (String.IsNullOrEmpty(userInput2))
            {
                int answer = math.MultiplyBy(userInput1);
                Console.WriteLine("{0} * 20 = {1}", userInput1, answer);
            }
            if (!String.IsNullOrEmpty(userInput2))
            {
                int userInput3 = Convert.ToInt32(userInput2);
                int answer = math.MultiplyBy(userInput1, userInput3);
                Console.WriteLine("{0} * {1} = {2}", userInput1, userInput3, answer);
            }
            Console.ReadLine();
        }
    }
}
