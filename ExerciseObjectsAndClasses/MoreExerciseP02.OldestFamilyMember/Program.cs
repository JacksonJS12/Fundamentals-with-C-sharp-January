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
            public int OldestPerson { get; set; }
            public Person(string name, int age, List<int> ages)
            {
                this.Name = name;
                this.Age = age;
                ages.Add(Age);

                
                    int oldestPerson = 0;
                    
                    for (int i = 0; i < ages.Count; i++)
                    {
                        if (i == 0)
                        {
                            oldestPerson = ages[0];
                        }
                        else if (ages[i] > ages[i - 1])
                        {
                            oldestPerson = ages[i];
                        }
                    }
                    this.OldestPerson = oldestPerson;
                    
                


            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<string> members = new List<string>();
            List<int> ages = new List<int>();
            for (int i = 0; i < num; i++)
            {
                List<string> member = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string memberName = member[0];
                int memberAge = int.Parse(member[1]);


                Family newMember = new Family(memberName, members);
                Person oldestPerson = new Person(memberName, memberAge, ages);

            }
        }
    }
}
