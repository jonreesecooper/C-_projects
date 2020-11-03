using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number.");
            string userInput = Console.ReadLine();
            int userInteger = Convert.ToInt32(userInput);
            int userMult = userInteger * 50;
            Console.WriteLine(userInteger + " times 50 = " + userMult);
            Console.WriteLine("Please enter another whole number.");
            string userInput2 = Console.ReadLine();
            int userInteger2 = Convert.ToInt32(userInput2);
            int userAdd = userInteger2 + 25;
            Console.WriteLine(userInteger2 + " plus 25 = " + userAdd);
            Console.WriteLine("Please enter another whole number.");
            string userInput3 = Console.ReadLine();
            float userInteger3 = Convert.ToSingle(userInput3);
            double userDivide = userInteger3 / 12.5;
            Console.WriteLine(userInteger3 + " divided by 12.5 = " + userDivide);
            Console.WriteLine("Please enter another whole number.");
            string userInput4 = Console.ReadLine();
            int userInteger4 = Convert.ToInt32(userInput4);
            bool userBool = userInteger4 > 50;
            Console.WriteLine("True or false, " + userInteger4 + " is greater than 50: " + userBool);
            Console.WriteLine("Please enter another whole number.");
            string userInput5 = Console.ReadLine();
            int userInteger5 = Convert.ToInt32(userInput5);
            int userRemainder = userInteger5 % 7;
            Console.WriteLine(userInteger5 + " divided by 7 gives a remainder of " + userRemainder);
            Console.ReadLine();


        }
    }
}
