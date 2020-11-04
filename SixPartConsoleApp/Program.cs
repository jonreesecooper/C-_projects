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


            string[] newArray = new string[] { "Hello, ", "this", "is", "my", "array!" };
            bool whileBool = false;
            while (!whileBool)
            {
                foreach (string item in newArray)
                {
                    Console.WriteLine(item);
                }
                // the following fixes the infinite while loop
                whileBool = true;
            }

            int lessThan = 10;
            while (lessThan < 14)
            {
                Console.WriteLine(lessThan);
                lessThan++;
            }

            int orEqual = 15;
            while (orEqual <= 19)
            {
                Console.WriteLine(orEqual);
                orEqual++;
            }

            List<string> lastNames = new List<string>() { "Cooper", "Gouldner", "Johnson", "Zuniga", "Gailey", "Olmedo" };
            Console.WriteLine("Please enter a last name to search.");
            string nameSearch = Console.ReadLine();
            bool newBool = false;
            while (!newBool)
            {
                if (lastNames.Contains(nameSearch) == true)
                {
                    Console.WriteLine("A match was found at index: " + lastNames.IndexOf(nameSearch));
                    newBool = true;
                }
                else
                {
                    Console.WriteLine("No matches found for that search.");
                    Console.WriteLine("Please enter a last name to search.");
                    nameSearch = Console.ReadLine();
                }
            }

            List<string> videoGames = new List<string>() { "Borderlands", "Fallout 4", "Final Fantasy XV", "Borderlands", "Dishonored" };
            Console.WriteLine("Please enter a video game to search.");
            string gameSearch = Console.ReadLine();
            for (int i = 0; i < videoGames.Count; i++)
            {
                bool thirdBool = false;
                while(!thirdBool)
                {
                    if (videoGames[i] == gameSearch)
                    {
                        Console.WriteLine("A match was found at index: " + videoGames.IndexOf(videoGames[i]));
                        thirdBool = true;
                    }
                    else
                    {
                        Console.WriteLine("Oops, no entries found!");
                        thirdBool = true;
                    }
                }

            }

            Console.ReadLine();
        }
    }
}
