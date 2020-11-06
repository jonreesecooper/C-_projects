using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOutputOverload
{
    static class StaticClass
    {
        static void OutputParams(out int first, out int second)
        {
            first = 2;
            second = 1;
            int results1 = first + second;
            int results2 = first - second;
            results1 = first;
            results2 = second;
        }

        static void OutputParams(out int first, out int second, out int third)
        {
            first = 2;
            second = 1;
            third = 1;
            int results1 = first + second;
            int results2 = first - second;
            int results3 = first + second + third;
            results1 = first;
            results2 = second;
            results3 = third;
        }
    }
}
