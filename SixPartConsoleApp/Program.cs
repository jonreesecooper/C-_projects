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
                if (videoGames[i] == gameSearch)
                {
                    Console.WriteLine("A match was found at index: " + i);
                }
            }
            if (videoGames.Contains(gameSearch) == false)
            {
                Console.WriteLine("No matches for that search.");
            }

            List<string> switchGames = new List<string>() { "Super Mario Maker 2", "The Legend of Zelda: Link\'s Awakening", "Mario Kart 8 Deluxe", "Super Mario Maker 2" };
            List<string> switchGames1 = new List<string>();
            foreach (string game in switchGames)
            {
                if (switchGames1.Contains(game))
                {
                    switchGames1.Add(game + "- already exists in list");
                }
                else
                {
                    switchGames1.Add(game);
                }
            }
            foreach (string game in switchGames1)
            {
                Console.WriteLine(game);
            }
            Console.ReadLine();
        }   
    }
}
