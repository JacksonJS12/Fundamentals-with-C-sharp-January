using System;
using System.Linq;

namespace P01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] cmdArgs = command
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArgs[0];

                if (cmdType == "Move")
                {
                    int numOfLetters = int.Parse(cmdArgs[1]);
                    string firstLetter = string.Empty;
                    for (int index = 0; index < numOfLetters; index++)
                    {
                        firstLetter = word[0].ToString();
                        word = word.Remove(0, 1);
                        word = word + firstLetter;
                        
                    }
                }

                else if (cmdType == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];

                    word = word.Insert(index, value);
                }

                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    word = word.Replace(substring, replacement);
                   
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {word}");
        }
    }
}
