using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                int num = i;
                sum = 0;
                while (num != 0)
                {
                    int slenderness = num % 10;
                    num /= 10;
                    sum += slenderness;
                }
                bool isValid = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{i} -> {isValid}");

            }


        }
    }
}
