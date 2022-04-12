using System;

namespace P01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopsString = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] cmdArgs = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Add Stop")
                {
                 
                    int index = int.Parse(cmdArgs[1]);
                    string insertString = cmdArgs[2];

                    stopsString = InsertStringAtIndex(stopsString, index, insertString);
                    Console.WriteLine(stopsString);

                }
                else if (cmdType == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    stopsString = RemoveStrignInRange(stopsString, startIndex, endIndex);
                    Console.WriteLine(stopsString);
                }
                else if (cmdType == "Switch")
                {
                    string oldString = cmdArgs[1];
                    string newString = cmdArgs[2];

                    stopsString = ReplaceAllOccurances(stopsString, oldString, newString);
                    Console.WriteLine(stopsString);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stopsString}");
        }

        static string ReplaceAllOccurances(string originalString, string oldString, string newString)
        {
            string modifiedString = originalString.Replace(oldString, newString);
               
            return modifiedString;
        }
        static string RemoveStrignInRange(string originalString, int startIndex, int endIndex)
        {
            if (!IsIndexValidateIndex(originalString, startIndex))
            {
                return originalString;
            }

            if (!IsIndexValidateIndex(originalString, endIndex))
            {
                return originalString;
            }

            string modifiedString = originalString.Remove(startIndex, (endIndex - startIndex) + 1);
            return modifiedString;
        }
        static string InsertStringAtIndex(string originalString, int insertIndex, string insertString)
        {
            if (!IsIndexValidateIndex(originalString, insertIndex))
            {
                return originalString;
            }

            string modifirfStr = originalString.Insert(insertIndex, insertString);

            return modifirfStr;
        }

        static bool IsIndexValidateIndex(string str, int index)
        {
            return index >= 0 && index < str.Length;
        }
    }
}
