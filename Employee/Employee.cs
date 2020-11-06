using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee: Person, IQuittable
    {
        public void Quit()
    {
        Console.WriteLine("I quit!");
    }
        public static Person operator ==(Person person, Person person1)
        {
            if (person.Id == person1.Id)
            {
                Console.WriteLine("It's a match!");
            }
            if (person.Id != person1.Id)
            {
                Console.WriteLine("It is not a match.");
            }
        }
    }
}
