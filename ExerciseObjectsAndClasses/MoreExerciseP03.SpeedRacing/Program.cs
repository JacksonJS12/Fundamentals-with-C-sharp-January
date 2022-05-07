using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreExerciseP03.SpeedRacing
{
    internal class Program
    {
        class Car
        {
            public string Model { get; set; }
            public double FuelAmount { get; set; }
            public double FuelConsumptionPerKilometer { get; set; }
            public int TraveledDistance { get; set; }
            public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer, int traveledDistance)
            {
                this.Model = model;
                this.FuelAmount = fuelAmount;
                this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
                this.TraveledDistance = traveledDistance;
            }
            public void MoveThatDistance(List<Car> cars, string carModel, int amountOfKm, Car car)
            {
                if (car.Model == carModel)
                {

                    double fuelAmont = car.FuelAmount - amountOfKm * car.FuelConsumptionPerKilometer;
                    if (fuelAmont > 0)
                    {
                        car.TraveledDistance += amountOfKm;
                        car.FuelAmount = fuelAmont;

                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");

                    }
                }
            }

        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            int traveledDistance = 0;
            for (int i = 0; i < num; i++)
            {
                string[] carsInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = carsInfo[0];
                double fuelAmout = double.Parse(carsInfo[1]);
                double fuelConsumptionFor1km = double.Parse(carsInfo[2]);

                Car car = new Car(model, fuelAmout, fuelConsumptionFor1km, traveledDistance);
                cars.Add(car);

            }
            string command = Console.ReadLine();

            while (command != "End")
            {

                string[] cmdInfo = command
                    .Split()
                    .ToArray();

                string carModel = cmdInfo[1];
                int amountOfKm = int.Parse(cmdInfo[2]);

                foreach (var car in cars)
                {
                    car.MoveThatDistance(cars, carModel, amountOfKm, car);
                }

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
