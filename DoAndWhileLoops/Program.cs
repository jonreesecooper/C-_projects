using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAndWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What\'s my mother f@$king name?");
            string answer = Console.ReadLine();

            bool guess = false;
            while (!guess)
            {
                switch (answer)
                {
                    case "snoop doggy dogg":
                        Console.WriteLine("Answers are case sensetive");
                        Console.WriteLine("What\'s my mother f@$king name?");
                        answer = Console.ReadLine();
                        break;
                    case "Snoop Doggy Dogg":
                        Console.WriteLine("You're damn right it is!");
                        guess = true;
                        break;
                    case "serial killa":
                        Console.WriteLine("Answers are case sensetive");
                        Console.WriteLine("What\'s my mother f@$king name?");
                        answer = Console.ReadLine();
                        break;
                    case "Serial Killa":
                        Console.WriteLine("Deep cut, niiiiice.");
                        guess = true;
                        break;
                    default:
                        Console.WriteLine("Do you even listen to hip-hop?");
                        Console.WriteLine("What\'s my mother f@$king name?");
                        answer = Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine("How many joints does Brad Lee smoke in the morning/at night/in the afternoon?");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            bool guess2 = answer2 == 2;
            do
            {
                switch (answer2)
                {
                    case 10:
                        Console.WriteLine("That seems excessive, even for Brad Lee");
                        Console.WriteLine("How many joints does Brad Lee smoke in the morning/at night/in the afternoon?");
                        answer2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("You're just a little short, there.");
                        Console.WriteLine("How many joints does Brad Lee smoke in the morning/at night/in the afternoon?");
                        answer2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("And it makes him feel alright.");
                        guess2 = true;
                        break;
                    default:
                        Console.WriteLine("That is the incorrect number of joints.");
                        Console.WriteLine("How many joints does Brad Lee smoke in the morning/at night/in the afternoon?");
                        answer2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!guess2);
            Console.ReadLine();
        }
    }
}
