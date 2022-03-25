using System;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string number = Console.ReadLine();

            //Action
            long factorialSum = 0;
            for (int i = 0; i <= number.Length - 1; i++)
            {
                //Degit as an ASCII character 
                char currCh = number[i];
                int currDigit = (int)currCh - 48;

                long currDigitFactorial = 1;
                for (int r = currDigit; r > 1; r--)
                {
                    currDigitFactorial *= r;
                }
                factorialSum += currDigitFactorial;

            }

            //Output
            if (factorialSum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

