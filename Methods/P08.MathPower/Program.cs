using System;

namespace P08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double powerReault = MathPower(@base, power);
            Console.WriteLine(powerReault);
        }

        static double MathPower(double @base, double power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= @base;
            }

            return result;
        }
    }
}
