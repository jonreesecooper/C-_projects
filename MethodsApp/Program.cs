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
            int userInput = Convert.ToInt32(Console.ReadLine());
            int firstAnswer = AddingTo(userInput);
            Console.WriteLine(firstAnswer);
            Console.ReadLine();
        }
    }
}
