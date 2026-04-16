using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;

namespace C__LINQ
{
    public record Employee(int Id, string Department, double Salary);
    internal class EmployeeManagement
    {
        
        static void Main()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "IT", 60000),
                new Employee(2, "HR", 45000),
                new Employee(3, "IT", 75000),
                new Employee(4, "Finance", 50000),
                new Employee(5, "HR", 48000),
                new Employee(6, "IT", 82000),
                new Employee(7, "Finance", 53000),
                new Employee(8, "IT", 67000),
                new Employee(9, "HR", 46000),
                new Employee(10, "Finance", 72000)
            };

            /*
            //1. Get employees from "IT" department

            var IT_emp = from emp in employees
                         where emp.Department == "IT"
                         select emp;
            foreach (var item in IT_emp)
            {
                Console.WriteLine(item);
            }

            //2. Get highest salary employee
            
            var max_sal = (from emp in employees

                           select emp.Salary).Max();
            Console.WriteLine(max_sal);
            

            //3.Get average salary

            var avg_sal = (from emp in employees

                           select emp.Salary).Average();
            Console.WriteLine(avg_sal);
            

            //4. Group employees by Department
            var grp_emp = (from emp in employees
                           group emp by emp.Department);

            foreach (var item in grp_emp)
            {
                Console.WriteLine("Department: "+ item.Key);

                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine();
            }
            

            //5. Count employees in each department
            var grp_emp_count = (from emp in employees
                                 group emp by emp.Department);
            foreach (var item in grp_emp_count)
            {
                Console.WriteLine(item.Count());
            }
           


            //--------------------------
            //expert:
            var sort_emp = (employees
                .OrderBy(e => e.Department)
                .ThenByDescending(e => e.Salary));
            foreach (var item in sort_emp)
            {
                Console.WriteLine(item);
                
            }
            

            var dashboard = employees
                .GroupBy(e => e.Department)
                .Select(e => new
                {
                    Department = e.Key,
                    avg_sal = e.OrderByDescending(e => e.Salary)
                });
            foreach (var item in dashboard)
            {
                Console.WriteLine(item.Department);
                foreach (var item1 in item.avg_sal)
                {
                    Console.WriteLine(item1);
                }

            }
            */



        }
    }
}
