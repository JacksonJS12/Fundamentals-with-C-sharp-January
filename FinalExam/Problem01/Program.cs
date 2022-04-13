using System;
using System.Linq;

namespace Problem01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArgs[0];

                if (cmdType == "Translate")
                {
                    char @char = char.Parse(cmdArgs[1]);
                    char replacement = char.Parse(cmdArgs[2]);

                    input = input.Replace(@char, replacement);
                    Console.WriteLine(input);
                }
                else if (cmdType == "Includes")
                {
                    string substring = cmdArgs[1];

                    Console.WriteLine(input.Contains(substring));
                }
                else if (cmdType == "Start")
                {
                    string substring = cmdArgs[1];

                    Console.WriteLine(input.StartsWith(substring));
                }
                else if (cmdType == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (cmdType == "FindIndex")
                {
                    char @char = char.Parse(cmdArgs[1]);
                    int findIndex = input.LastIndexOf(@char);
                    Console.WriteLine(findIndex);
                }
                else if (cmdType == "Remove")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int count = int.Parse(cmdArgs[2]);

                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);

                }

                command = Console.ReadLine();
            }
        }
    }
}
