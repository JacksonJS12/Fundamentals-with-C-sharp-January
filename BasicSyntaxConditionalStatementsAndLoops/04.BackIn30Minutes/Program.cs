﻿using System;

namespace P04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine()) + 30;

            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
