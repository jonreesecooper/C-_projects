using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic arithmetic = new Arithmetic();
            int intArithmetic = arithmetic.AddingTo(15);
            Console.WriteLine("15 + 25 = {0}", intArithmetic);
            int decArithmetic = arithmetic.AddingTo(20.0m);
            Console.WriteLine("20 + 50 = {0}", decArithmetic);
            int strArithmetic = arithmetic.AddingTo("55");
            Console.WriteLine("55 + 75 = {0}", strArithmetic);
            Console.ReadLine();
        }
    }
}
