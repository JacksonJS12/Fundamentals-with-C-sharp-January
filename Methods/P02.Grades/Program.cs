using System;

namespace P02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);

        }

        static void PrintGrade(double grade)
        {
            //2.00 – 2.99 - "Fail"
            //3.00 – 3.49 - "Poor"
            //3.50 – 4.49 - "Good"
            //4.50 – 5.49 - "Very good"
            //5.50 – 6.00 - "Excellent"

            if (grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if ( grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
