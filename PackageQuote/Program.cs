using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Please enter your package weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if(packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped with Package Express.  Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the width of your package");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the height of your package.");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the length of your package.");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                if(packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped by Package Express");
                    Console.ReadLine();
                }
                else
                {
                    int dimensions = packageWidth * packageHeight * packageLength;
                    int mass = dimensions * packageWeight;
                    int quote = mass / 100;
                    Console.WriteLine("Your estimated total for shipping the package is $" + quote);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
