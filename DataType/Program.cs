using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 3.15m;
            Console.WriteLine("The amount is {0}", number.Amount);
            Console.ReadLine();
        }
    }
}
