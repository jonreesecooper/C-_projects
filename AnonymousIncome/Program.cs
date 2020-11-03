using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program \nPerson 1\nEnter hourly rate (whole number):");
            string person1rate = Console.ReadLine();
            int person1hourly = Convert.ToInt32(person1rate);
            Console.WriteLine("Enter hours worked per a week (whole number):");
            string person1hours = Console.ReadLine();
            int person1weekly = Convert.ToInt32(person1hours);
            Console.WriteLine("Person 2\nEnter hourly rate (whole number):");
            string person2rate = Console.ReadLine();
            int person2hourly = Convert.ToInt32(person2rate);
            Console.WriteLine("Enter hours worked per a week (whole number):");
            string person2hours = Console.ReadLine();
            int person2weekly = Convert.ToInt32(person2hours);
            int person1salary = person1hourly * person1weekly * 52;
            int person2salary = person2hourly * person2weekly * 52;
            bool compare = person1salary > person2salary;
            Console.WriteLine("Annual salary of Person 1: $" + person1salary);
            Console.WriteLine("Annual salary of Person 2: $" + person2salary);
            Console.WriteLine("Does Person 1 make more money than Person 2? " + compare);
            Console.ReadLine();
            

        }
    }
}
