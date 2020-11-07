using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<Employee> thejoes = new List<Employee>();
            employees.Add(new Employee() { Id = 1, FirstName = "Joe", LastName = "Momma" });
            employees.Add(new Employee() { Id = 2, FirstName = "Jim", LastName = "Jimson" });
            employees.Add(new Employee() { Id = 3, FirstName = "Dan", LastName = "Danson" });
            employees.Add(new Employee() { Id = 4, FirstName = "Bill", LastName = "Billson" });
            employees.Add(new Employee() { Id = 5, FirstName = "Joe", LastName = "Biden" });
            employees.Add(new Employee() { Id = 6, FirstName = "Mary", LastName = "Maryson" });
            employees.Add(new Employee() { Id = 7, FirstName = "Kamala", LastName = "Harris" });
            employees.Add(new Employee() { Id = 8, FirstName = "Donald", LastName = "Doneson" });
            employees.Add(new Employee() { Id = 9, FirstName = "Felicia", LastName = "Feleciason" });
            employees.Add(new Employee() { Id = 10, FirstName = "Amy", LastName = "Amyson" });

            //foreach(Employee employee in employees)
            //{
            //    if(employee.FirstName == "Joe")
            //    {
            //        thejoes.Add(employee);
            //    }
            //}
            thejoes = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach(Employee employee in thejoes)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
            Console.ReadLine();
        }
    }
}
