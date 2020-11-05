using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidMath voidmath = new VoidMath();
            voidmath.DoMath(5, 2);
            voidmath.DoMath(input1: 6, input2: 7);
            Console.ReadLine();
        }
    }
}
