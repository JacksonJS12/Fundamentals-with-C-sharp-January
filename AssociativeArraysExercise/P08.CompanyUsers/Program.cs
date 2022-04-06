using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> companies = new Dictionary<string, HashSet<string>>();

            string command = Console.ReadLine();
            while (!command.Contains("End"))
            {
                string company = command.Split(" -> ")[0];
                string employee = command.Split(" -> ")[1];

                if (companies.ContainsKey(company))
                {
                    companies[company].Add(employee);
                }
                else
                {
                    var employees = new HashSet<string>() { employee };
                    companies.Add(company, employees);
                }

                command = Console.ReadLine();
            }

           
            companies.ToList().ForEach(x =>
            {
                Console.WriteLine($"{x.Key}");
                x.Value.ToList().ForEach(e =>
                {
                    Console.WriteLine($"-- {e}");
                });
            });
        }
    }
}