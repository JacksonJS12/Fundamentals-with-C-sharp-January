using System;
using System.Linq;

namespace P01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Reveal")
            {
                string[] cmdArgs = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];
                if (cmdType == "InsertSpace")
                {
                    int insertIndex = int.Parse(cmdArgs[1]);
                    message = message.Insert(insertIndex, " ");
                }
                else if (cmdType == "Reverse")
                {
                    string substring = cmdArgs[1];
                    if (message.Contains(substring))
                    {

                    int wordIndex = message.IndexOf(substring);
                    message = message.Remove(wordIndex, substring.Length);
                    message = message + string.Join("", substring.Reverse());
                    }
                    else
                    {
                        Console.WriteLine("error");
                        command = Console.ReadLine();
                        continue;
                    }
                    

                }
                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacementText = cmdArgs[2];

                    message = message.Replace(substring, replacementText);
                }
                Console.WriteLine(message);
                 command = Console.ReadLine();
            }
                Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
