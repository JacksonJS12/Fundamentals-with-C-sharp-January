using System;
using System.Collections.Generic;

namespace P04.Students
{
    internal class Program
    {
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }
        }
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] splitParams = command
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string firstName = splitParams[0];
                string lastName = splitParams[1];
                int age = int.Parse(splitParams[2]);
                string hometown = splitParams[3];

                Student newStudent = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Hometown = hometown
                };

                students.Add(newStudent);

                command = Console.ReadLine();
            }

            string hometownToSearch = Console.ReadLine();
            List<Student> filteredStudents = students.FindAll(students => students.Hometown == hometownToSearch);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
    }
}
