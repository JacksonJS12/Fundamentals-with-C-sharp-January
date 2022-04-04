using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Students
{
    internal class Program
    {
        class Student
        {
            public Student(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;
            }
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";

            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] studentArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currentStudentFirstName = studentArgs[0];
                string currentStudentLastName = studentArgs[1];
                double currentStudentGrade = double.Parse(studentArgs[2]);

                Student currStudent = new Student(currentStudentFirstName, currentStudentLastName, currentStudentGrade);

                students.Add(currStudent);

            }
            List<Student> orderedStudents = students
                .OrderByDescending(s => s.Grade)
                .ToList();

            foreach (Student student in orderedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
