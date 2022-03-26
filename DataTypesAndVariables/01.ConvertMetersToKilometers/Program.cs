using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meters = int.Parse(Console.ReadLine());
            decimal kilometers = (decimal)meters / 1000.0M;
            Console.WriteLine($"{ kilometers:F2}");
        }
    }
}
