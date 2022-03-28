using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayNum = int.Parse(Console.ReadLine());

            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"

            };

            if (dayNum >= 1 && dayNum <= daysOfWeek.Length)
            {
                Console.WriteLine(daysOfWeek[dayNum-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
