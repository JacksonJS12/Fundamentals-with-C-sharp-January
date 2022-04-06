using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] courseArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cousrseName = courseArgs[0];
                string studentName = courseArgs[1];

                if (!courseInfo.ContainsKey(cousrseName))
                {
                    courseInfo[cousrseName] = new List<string>();
                }

                courseInfo[cousrseName].Add(studentName);

                command = Console.ReadLine();
            }
            PrintCoursesInfo(courseInfo);
        }
        static void PrintCoursesInfo(Dictionary<string, List<string>> courseInfo)
        {
            foreach (var kvp in courseInfo)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;

                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var studentName in students)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
