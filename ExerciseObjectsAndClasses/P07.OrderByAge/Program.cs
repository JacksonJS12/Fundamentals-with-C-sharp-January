using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.OrderByAge
{
    class Program
    {
        class PersonInfo
        {
            public PersonInfo(string name, string id, int age)
            {
                this.Name = name;
                this.Id = id;
                this.Age = age;
            }
            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }
            public override string ToString()
            {
                return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";

            }
        }
        static void Main(string[] args)
        {
            List<PersonInfo> lines = new List<PersonInfo>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputParams = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = inputParams[0];
                string id = inputParams[1];
                int age = int.Parse(inputParams[2]);

                PersonInfo currLine = new PersonInfo(name, id, age);

                lines.Add(currLine);

                input = Console.ReadLine();
            }

            List<PersonInfo> orderedByAge = lines.OrderBy(x => x.Age).ToList();
            foreach (var line in orderedByAge)
            {
                Console.WriteLine(line);
            }

        }
    }
}