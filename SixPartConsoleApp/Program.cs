using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[] { "Jon ", "Adam ", "Charley ", "Ryan ", "Dave ", "Omar " };
            string[] emptyArray = new string[6];
            Console.WriteLine("Please provide some text to add to string.");
            string addString = Console.ReadLine();
            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = strArray[i] + addString;
            }
            foreach (string newString in strArray)
            {
                Console.WriteLine(newString);
            }
           

            bool whileBool = false;
            while (!whileBool)
            {
                foreach (string newString in strArray)
                {
                    Console.WriteLine(newString);
                }
                // the following fixes the infinite while loop
                whileBool = true;
            }

            int lessThan = 10;
            while (lessThan < 20)
            {
                Console.WriteLine(lessThan);
                lessThan++;
            }

            int orEqual = 15;
            while (orEqual <= 25)
            {
                Console.WriteLine(orEqual);
                orEqual++;
            }

            List<string> lastNames = new List<string>() { "Cooper", "Gouldner", "Johnson", "Zuniga", "Gailey", "Olmedo" };
            Console.WriteLine("Please enter a last name to search.");
            string nameSearch = Console.ReadLine();
            foreach (string name in lastNames)
            {
                if(name == nameSearch)
                {
                    Console.WriteLine(name);
                }
                else
                {
                    Console.Write("Oops, we have no last name meeting your search criteria!");
                }
            }

            Console.ReadLine();
        }
    }
}
