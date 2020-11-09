using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVarConstructorChain
{
    class Program
    {
        static void Main(string[] args)
        {
            const string mySchool = "The Tech Academy";
            var myName = "Jon";
            Student student1 = new Student(myName);
            Student student2 = new Student("Joe", "Python", mySchool);
            Console.WriteLine("{0} is studying {1} at {2}.", student1.Name, student1.Course, student1.School);
            Console.WriteLine("{0} is studying {1} at {2}.", student2.Name, student2.Course, student2.School);
            Console.ReadLine();
        }
    }
}
