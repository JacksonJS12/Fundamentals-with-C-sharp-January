using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreExerciseP01.CompanyRoster
{
    internal class Program
    {
        class Employee
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public Employee(string name, decimal salary)
            {
                this.Name = name;
                this.Salary = salary;
            }
        }
        class Department
        {
            public string DepartmentName { get; set; }
            public List<Employee> Employees { get; set; } = new List<Employee>();
            public decimal TotalSalaries { get; set; }

            public void AddNewEmployee(string name, decimal salary)
            {
                this.TotalSalaries += salary;
                this.Employees.Add(new Employee(name, salary));
            }

            public Department(string departmentName)
            {
                this.DepartmentName = departmentName;
            }
        }


        static void Main(string[] args)
        {
            List<Department> deparments = new List<Department>();
            int num = int.Parse(Console.ReadLine());


            for (int i = 0; i < num; i++)
            {
                string[] information = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                
                if(!deparments.Any(d => d.DepartmentName == information[2]))
                {
                    deparments.Add(new Department(information[2]));
                }

                deparments.Find(d => d.DepartmentName == information[2]).AddNewEmployee(information[0], decimal.Parse(information[1]));

            }

            Department bestDepartment = deparments.OrderByDescending(d => d.TotalSalaries / d.Employees.Count()).First();

    

            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");
            foreach (var employee in bestDepartment.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
}
