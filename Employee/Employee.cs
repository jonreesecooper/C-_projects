﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee<T>: Person, IQuittable
    {
        public List<T> Things { get; set; }
        public void Quit()
        {
        Console.WriteLine("I quit!");
        }
        //public static bool operator==(Employee person, Person person1)
        //{
        //    return (person.Id == person1.Id);
        //}
        //public static bool operator!=(Employee person, Person person1)
        //{
        //    return (person.Id != person.Id);
        //}

    }
}
