using System;
using System.Collections.Generic;

namespace P05.Students2._0
{
    internal class Program
    {
        class Student
        {
            public Student(
                string firstName, 
                string lastName,
                int age,
                string hometown)
            {
                FirstName = firstName;  
                LastName = lastName;
                Age = age;
                Hometown = hometown;
            }
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
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = splitParams[0];
                string lastName = splitParams[1];
                int age = int.Parse(splitParams[2]);
                string hometown = splitParams[3];

                bool doesStudentExist = DoesStudentExist(students, firstName, lastName);

                if (doesStudentExist)
                {
                    Student existingStudent = GetExistingStudent(students, firstName, lastName);

                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.Hometown= hometown;
                }
                else
                {

                    Student newStudent = new Student(
                        firstName,
                        lastName,
                        age,
                        hometown)
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = hometown
                    };

                    students.Add(newStudent);
                }


                command = Console.ReadLine();
            }

            string hometownToSearch = Console.ReadLine();
            List<Student> filteredStudents = students.FindAll(students => students.Hometown == hometownToSearch);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }

        private static Student GetExistingStudent(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }
            return null;
        }

        static bool DoesStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
