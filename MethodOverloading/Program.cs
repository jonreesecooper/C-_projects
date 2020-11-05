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
            Console.WriteLine(intArithmetic);
            int decArithmetic = arithmetic.AddingTo(20.0m);
            Console.WriteLine(decArithmetic);
            string strArithmetic = arithmetic.AddingTo("55");
            Console.WriteLine(Convert.ToInt32(strArithmetic));
            Console.ReadLine();
        }
    }
}
