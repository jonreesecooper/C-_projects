using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 };
            Employee employee1 = new Employee() { FirstName = "Jon", LastName = "Cooper", Id = 2 };
            IQuittable iquittable = new Employee();
            employee.SayName();
            iquittable.Quit();
            if(employee == employee1)
            {
                Console.WriteLine("It is a match!");
            }
            else
            {
                Console.WriteLine("It is not a match.");
            }
            Console.ReadLine();
        }
    }
}
