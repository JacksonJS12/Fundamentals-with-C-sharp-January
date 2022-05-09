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
            class Engine
            {
                public int EngineSpeed { get; set; }
                public int EnginePower { get; set; }
            }
            class Cargo
            {
                public int CargoWeight { get; set; }
                public int CargoType { get; set; }
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
            }
        }
    }
}
