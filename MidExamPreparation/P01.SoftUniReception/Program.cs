using System;

namespace P01.SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int answeredStudentsPerHour = firstEmployee + secondEmployee + thirdEmployee;

            int hours = 0;

            while (studentsCount >= 0)
            {
                if (hours % 4 != 0) // have a break for 1 hour after every 3th hour of work
                {
                    hours++;

                }
                for (int hour = 0; hour < 3; hour++)
                {
                    if (studentsCount <= 0)
                    {
                        break;
                    }
                    studentsCount -= answeredStudentsPerHour;
                    hours++;
                }
                if (studentsCount <= 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
