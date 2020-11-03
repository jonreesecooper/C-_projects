using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nDaily Report \nWhat is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int actualPage = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything?  Please type \'true\' or \'false\'");
            string needHelp = Console.ReadLine();
            bool helpAnswer = Convert.ToBoolean(needHelp);
            Console.WriteLine("Were there any positive experiences you'd like to share?  Please be specific.");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int actualStudy = Convert.ToInt32(studyHours);
            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great day!");
            Console.ReadLine();

        }
    }
}
