using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVarConstructorChain
{
    class Student
    {
        public Student(string name) : this(name, "C#", "The Tech Academy")
        {

        }
        public Student(string name, string course, string school)
        {
            Name = name;
            Course = course;
            School = school;
        }

        public string Name { get; set; }
        public string Course { get; set; }
        public string School { get; set; }
    }
}
