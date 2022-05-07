using System;
using System.Linq;

namespace MoreExerciseP03.SpeedRacing
{
    internal class Program
    {
        class Car
        {
            public string Model { get; set; }
            public int FuelAmount { get; set; }
            public double FuelConsumptionPerKilometer { get; set; }
            public int TraveledDistance { get; set; }
            public Car(string model, int fuelAmount, double fuelConsumptionPerKilometer, int traveledDistance)
            {
                this.Model = model;
                this.FuelAmount = fuelAmount;
                this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
                this.TraveledDistance = traveledDistance;
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] carsInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = carsInfo[0];
                int fuelAmout = int.Parse(carsInfo[1]);
                double fuelConsumptionFor1km = double.Parse(carsInfo[2]);


                string command = Console.ReadLine();
                int traveledDistance = 0;
                while (command != "End")
                {
                    Car car = new Car(model, fuelAmout, fuelConsumptionFor1km, traveledDistance);

                    string[] cmdInfo = command
                        .Split()
                        .ToArray();

                    string carModel = cmdInfo[1];
                    int amountOfKm = int.Parse(cmdInfo[2]);


                }
            }
        }
    }
}
