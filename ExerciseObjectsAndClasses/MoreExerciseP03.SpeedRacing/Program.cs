using System;
using System.Linq;

namespace MoreExerciseP03.SpeedRacing
{
    internal class Program
    {
        class Car
        {
            public string Model { get; set; }
            public int Fuel { get; set; }
            public double FuelConsumptionPerKilometer { get; set; }
            public int TraveledDistance { get; set; }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string car = Console.ReadLine();

                string command = Console.ReadLine();
                while (command != "End")
                {
                    string[] carInfo = command
                        .Split()
                        .ToArray();

                    string cmdType = carInfo[0];
                    string carModel = carInfo[1];
                    int amountOfKilometers = int.Parse(carInfo[2]);


                }
            }
        }
    }
}
