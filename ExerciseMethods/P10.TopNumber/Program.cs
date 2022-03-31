using System;
using System.Linq;

namespace P10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int numInNubers = 1; numInNubers <= number; numInNubers++)
            {
                int sumOfDigits = SumOfDigits(numInNubers);
                int isThereOddDigit = IsThereOddDigits(numInNubers);
                if (sumOfDigits == isThereOddDigit)
                {
                    Console.WriteLine(IsDigitDivisibleBy8(numInNubers, sumOfDigits));
                }
            }

        }

        static int SumOfDigits(int number)
        {

            int sumOfDigits = 0;
            if ((number % 10) != number)
            {
                do
                {
                    sumOfDigits = sumOfDigits + (number % 10);

                    number = number / 10;


                }
                while (number > 0);
                {
                    return sumOfDigits;

                }
            }
            else
            {
                return number;
            }

        }

        static int IsDigitDivisibleBy8(int number, int sumOfDigits)
        {


            if (sumOfDigits % 8 == 0)
            {
                return number;
            }
            else
            {
                return 0;
            }

        }
        static int IsThereOddDigits(int number)
        {
            int[] oddNum = number.Where

        }
        

    }

}
