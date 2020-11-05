using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number.");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another whole number.");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            Arithmetic result = new Arithmetic();
            int firstAnswer = result.AddingTo(userInput1, userInput2);
            Console.WriteLine(userInput1 + " + " + userInput2 + " = " + firstAnswer);
            int secondAnswer = result.SubtractingFrom(userInput1, userInput2);
            Console.WriteLine(userInput1 + " - " + userInput2 + " = " + secondAnswer);
            int thirdAnswer = result.MultiplyBy(userInput1, userInput2);
            Console.WriteLine(userInput1 + " * " + userInput2 + " = " + thirdAnswer);
            Console.ReadLine();
        }
    }
}
