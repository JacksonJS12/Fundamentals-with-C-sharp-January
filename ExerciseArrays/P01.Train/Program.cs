using System;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] passengers = new int[wagons];

            int sumOfPassengersInWagon = 0;

            int i;
            for (i = 0; i < wagons; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sumOfPassengersInWagon += passengers[i];

            }

            for (int j = wagons; j <= passengers.Length; j++)
            {

                Console.Write(String.Join(' ', passengers));
                Console.WriteLine();
            }
            Console.WriteLine(sumOfPassengersInWagon);
        }
    }
}
