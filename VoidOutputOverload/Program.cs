using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOutputOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Outputs outputs = new Outputs();
            Console.WriteLine("Please enter a whole number.");
            int input = Convert.ToInt32(Console.ReadLine());
            int output = 0;
            outputs.ByTwo(input, out output);
            Console.WriteLine("{0} / 2 = {1}", input, output);
            Console.ReadLine();

        }
    }
}
