    using System;

    namespace _4._Print_and_Sum
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //Intput
                int startNum = int.Parse(Console.ReadLine());
                int endNum = int.Parse(Console.ReadLine());

                int sum = 0;
                int num = 0;

                //Action
                for (int i = startNum; i <= endNum; i++)
                {
                    sum += i;
                    Console.Write($"{i} ");
                }


                //Output
                Console.WriteLine();  
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
