using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    public class Math
    {
        public int MultiplyBy(int userInput1, int userInput3 = 20)
        {
            return userInput1 * userInput3;
        }
    }
}
