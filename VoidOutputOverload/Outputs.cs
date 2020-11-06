using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOutputOverload
{
    public class Outputs
    {
        public void ByTwo(int input, out int output)
        {
            output = 1;
            int results = input * output;
            output = results / 2;
        }
    }
}
