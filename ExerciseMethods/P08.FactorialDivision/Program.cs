using System;

namespace P08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());


            double total = Factorial(numberOne) / Factorial(numberTwo);
            Console.WriteLine($"{total:f2}");
        }
        static double Factorial(double number)
        {
            double factorialNumSum = 1;

            
                for (double num1 = 1; num1 <= number; num1++)
                {
                    factorialNumSum *= num1;
                }

                return factorialNumSum;
            
        }
    }
}
