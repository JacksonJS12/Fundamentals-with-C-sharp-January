﻿using System;

namespace P01.StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
           
            
        }
    }
}
