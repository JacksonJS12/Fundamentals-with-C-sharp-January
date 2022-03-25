using System;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double averageSpeed = double.Parse(Console.ReadLine());
            double rocketFuelPer100km = double.Parse(Console.ReadLine());

            double totalDistance = 384400 * 2;
            double totalTime = Math.Ceiling(totalDistance / averageSpeed) + 3;
            double totalRocketFuel = (rocketFuelPer100km * totalDistance) / 100;

            Console.WriteLine(totalTime);
            Console.WriteLine(totalRocketFuel);


        }
    }
}
