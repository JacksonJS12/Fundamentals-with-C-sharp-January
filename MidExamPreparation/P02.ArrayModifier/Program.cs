using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "swap")
                {
                    int firstIndex = int.Parse(cmdArgs[1]);
                    int secondIndex = int.Parse(cmdArgs[2]);

                    int firstNum = array[firstIndex]; 
                    array[firstIndex] = array[secondIndex]; 
                    array[secondIndex] = firstNum;
                    
                }
                else if (cmdType == "multiply")
                {
                    int firstIndex = int.Parse(cmdArgs[1]);
                    int secondIndex = int.Parse(cmdArgs[2]);

                    int firstNum = array[firstIndex];
                    int secondNum = array[secondIndex];

                    int multiply = firstNum * secondNum;
                    array[firstIndex] = multiply;

                }
                else if (cmdType == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] -= 1;
                    }
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
