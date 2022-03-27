using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int numOfFullCourse = 0;

            if (num % capacity == 0)
            {
                numOfFullCourse = num / capacity;

            }
            else
            {
                numOfFullCourse = num % capacity;

            }
        }
    }
} 
