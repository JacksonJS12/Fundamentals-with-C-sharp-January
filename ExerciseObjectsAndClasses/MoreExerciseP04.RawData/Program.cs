using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreExerciseP04.RawData
{
    internal class Program
    {
        class Car
        {
            public string Model { get; set; }

            public class Engine
            {
                public int EngineSpeed { get; set; }
                public int EnginePower { get; set; }
                public Engine(int engineSpeed, int enginePower)
                {
                    this.EngineSpeed = engineSpeed;
                    this.EnginePower = enginePower;
                }

            }
            public Engine EngineSpeedAndPower { get; set; }
          
            public class Cargo
            {
                public int CargoWeight { get; set; }
                public string CargoType { get; set; }
                public Cargo(int cargoWeight, string cargoType)
                {
                    this.CargoWeight = cargoWeight;
                    this.CargoType = cargoType;
                }
            }
            public Cargo CargoWeightAndType { get; set; }

            public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
            {
                this.Model = model;
                this.EngineSpeedAndPower = new Engine(engineSpeed, enginePower);
                this.CargoWeightAndType = new Cargo(cargoWeight, cargoType);
            }
           
            public void Print(Car car)
            {
                if (this.CargoWeightAndType.CargoType == "fragile")
                {
                    if (this.CargoWeightAndType.CargoWeight < 1000)
                    {
                        Console.WriteLine(car.Model);
                    }
                   
                }
                else if (this.CargoWeightAndType.CargoType == "flamable")
                {
                    if (this.EngineSpeedAndPower.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numOfCars; i++)
            {
                string[] carParams = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = carParams[0];
                int engineSpeed = int.Parse(carParams[1]);
                int enginePower = int.Parse(carParams[2]);
                int cargoWeight = int.Parse(carParams[3]);
                string cargoType = carParams[4];

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);
                cars.Add(car);

            }

            foreach (var car in cars)
            {
                car.Print(car);
            }
        }
    }
}
