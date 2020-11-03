using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageVerify = Console.ReadLine();
            int ageInt = Convert.ToInt32(ageVerify);
            Console.WriteLine("Have you ever had a DUI (true or false)?");
            string duiVerify = Console.ReadLine();
            bool duiBool = Convert.ToBoolean(duiVerify);
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsVerify = Console.ReadLine();
            int ticketsInt = Convert.ToInt32(ticketsVerify);
            bool qualify = ageInt >= 15 && duiBool == false && ticketsInt < 3;
            Console.WriteLine("Do you qualify?");
            Console.WriteLine(qualify);
            Console.ReadLine();
            

        }
    }
}
