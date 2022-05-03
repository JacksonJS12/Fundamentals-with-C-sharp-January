using System;
using System.Linq;

namespace MoreExerciseP01.CompanyRoster
{
    internal class Program
    {
        class Employee
        {
            public Employee(string name, decimal salary, string department)
            {
                this.Name = name;
                this.Salary = salary;
                this.Department = department;
            }
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public string Department { get; set; }
            
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < num; i++)
            {
                string[] information = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = information[0];
                decimal salary = decimal.Parse(information[1]);
                string department = information[2];


            }
       

            Console.WriteLine($"Highest Average Salary: ");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
