using System;
using System.Linq;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());

            string[] previouseDnaSequence = new string[dnaLenght];

            string command = Console.ReadLine();
            string[] biggerArray = new string[dnaLenght];
            while (command != "Clone them!")
            {
                string[] dnaSequence = command
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int lastIndex = 0;
                int subsequence = 0;
                for (int i = 0; i < dnaLenght; i++)
                {

                    if (!(i == 0))
                    {
                        lastIndex = i - 1;

                    }
                    else
                    {
                        continue;
                    }

                    if (dnaSequence[i] == dnaSequence[lastIndex])
                    {
                        subsequence++;
                    }


                }
                if (previouseDnaSequence[0] == null)
                {
                    previouseDnaSequence = dnaSequence;
                    continue;
                }
                for (int i = 0; i < dnaLenght; i++)
                {
                    if (int.Parse(dnaSequence[i]) > int.Parse(previouseDnaSequence[i]))
                    {
                        biggerArray = dnaSequence;
                        break;
                    }
                    else if (int.Parse(dnaSequence[i]) == int.Parse(previouseDnaSequence[i]))
                    {
                        continue;
                    }
                    else
                    {
                        biggerArray = previouseDnaSequence;
                        break;
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
