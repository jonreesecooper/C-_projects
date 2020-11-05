using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Arithmetic
    {
        public int AddingTo(int x)
        {
            return x + 25;
        }

        public int AddingTo(decimal x)
        {
            return Convert.ToInt32(x + 50);
        }

        public string AddingTo(string x)
        {
            int newX = Convert.ToInt32(x);
            return newX + 75;
        }
    }
}
