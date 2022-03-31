using System;

namespace P07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            NxN(number);
        }

        static void NxN(int number)
        {
            for (int rows = 0; rows < number; rows++)
            {
                for (int col = 1; col < number; col++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine(number);
            }
        }
    }
}
