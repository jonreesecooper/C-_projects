using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Jon is really ";
            string second = "good at ";
            string third = "concatenating strings!";
            string concat = first + second + third;
            Console.WriteLine(concat);
            string upper = concat.ToUpper();
            Console.WriteLine(upper);
            StringBuilder sb = new StringBuilder();
            sb.Append("This is my first sentence.  ");
            sb.Append("This is my second sentence.  ");
            sb.Append("This right here, well this is my third sentence.  ");
            sb.Append("Wow, what an amazing paragraph!");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
