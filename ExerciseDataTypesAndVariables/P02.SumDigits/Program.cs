using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           
            

            int sum = 0;

            for (int i = num % 10; i != 0; i-- )
            {
               sum += num 
            }

            Console.WriteLine(sum);
        }
    }
}
