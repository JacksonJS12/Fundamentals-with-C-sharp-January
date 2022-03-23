using System;

namespace P12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(num)}");
                
            } 

            if (num % 2 != 0)
            {
                for (int i = 0; ; i++)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"The number is: {Math.Abs(num)}");
                        break;
                    }
                    Console.WriteLine("Please write an even number.");
                    num = int.Parse(Console.ReadLine());
                }
            }
            

        }
    }
}
