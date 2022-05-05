using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreExerciseP02.OldestFamilyMember
{
    internal class Program
    {
        class Family
        {
            public List<string> FamilyMembers { get; set; }
            public string Member { get; set; }

            public Family(string member, List<string> members)
            {
                this.Member = member;
                this.FamilyMembers = members;
                FamilyMembers.Add(Member);
            }

        }
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int OldestPersonAge { get; set; }
            public string OldestPersonName { get; set; }
            public Person(string name, int age, List<int> ages, List<string> members)
            {
                this.Name = name;
                this.Age = age;
                ages.Add(Age);


                int oldestPersonAge = 0;
                string oldestPersonName = string.Empty;

                for (int i = 0; i < ages.Count; i++)
                {
                    if (i == 0)
                    {
                        oldestPersonAge = ages[0];
                        oldestPersonName = members[0];
                    }
                    else if (ages[i] > ages[i - 1])
                    {
                        oldestPersonAge = ages[i];
                        oldestPersonName = members[i];
                    }
                }
                this.OldestPersonAge = oldestPersonAge;
                this.OldestPersonName = oldestPersonName;



            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<string> members = new List<string>();
            List<int> ages = new List<int>();
            string oldestPersonName = string.Empty;
            int oldestPersonAge = 0;
            for (int i = 0; i < num; i++)
            {
                List<string> member = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string memberName = member[0];
                int memberAge = int.Parse(member[1]);


                Family newMember = new Family(memberName, members);
                Person oldestPerson = new Person(memberName, memberAge, ages, members);

                oldestPersonName = oldestPerson.OldestPersonName;
                oldestPersonAge = oldestPerson.OldestPersonAge;
            }
            Console.WriteLine($"{oldestPersonName} {oldestPersonAge}");
        }
    }
}
