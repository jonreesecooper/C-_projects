using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class VoidMath
    {
        public void DoMath(int input1, int input2)
        {
            int voided = input1 * 5;
            int displayed = input2;
            Console.WriteLine("The second parameter of this method is {0}", displayed);
        }
    }
}
