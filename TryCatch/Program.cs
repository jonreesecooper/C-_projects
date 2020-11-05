using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            Console.WriteLine("Please enter a number:");
            try
            {
                foreach(int number in intList)
                {
                    int answer = Convert.ToInt32(Console.ReadLine());
                    int result = number / answer;
                    Console.WriteLine(number + " divided by " + answer + " equals " + result);
                }

            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
               Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Operation completed, moving on with program.");
                Console.ReadLine();
            }

        }
    }
}
