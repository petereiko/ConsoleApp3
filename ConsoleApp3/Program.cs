using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                     Age=28,
                     Department="HR"
                },
                new Employee
                {
                     Age=29,
                     Department="HR"
                },
                new Employee
                {
                     Age=30,
                     Department="HR"
                },
                new Employee
                {
                     Age=31,
                     Department="HR"
                }
            };

            count = employees.Count;

            employees.Add(new Employee
            {
                Age = 32,
                Department = "IT"
            });

            count = employees.Count;

            //filter employees by Department

            employees.AddRange(new List<Employee>
             {
                  new Employee
                  {
                       Age=33,
                       Department="Management"
                  },
                  new Employee
                  {
                      Age=34,
                       Department="Risk"
                  }
             });
            List<string> departments = employees.Select(e => e.Department).ToList();

        }
    }

    public class Employee
    {
        public int Age { get; set; }
        public string Department { get; set; }
    }



}
