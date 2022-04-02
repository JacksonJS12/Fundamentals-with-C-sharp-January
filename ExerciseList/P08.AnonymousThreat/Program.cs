using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArgs[0];

                if (cmdType == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    Merge(words, startIndex, endIndex);
                }

                else if (cmdType == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partitionsCount = int.Parse(cmdArgs[2]);

                    Divide(words, index, partitionsCount);
                }

            }
            Console.WriteLine(string.Join(" ", words));
        }

        static void Merge(List<string> words, int startIndex, int endIndex)
        {
            if (!IsIndexValid(words, startIndex))
            {
                startIndex = 0;
            }

            if (!IsIndexValid(words, startIndex))
            {
                endIndex = words.Count - 1;
            }

            StringBuilder merged = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                merged.Append(words[i]);
                words.RemoveAt(startIndex);
            }

            words.Insert(startIndex, merged.ToString());
        }


        static void Divide(List<string> words, int elementIndex, int partitionsCount)
        {
            string word = words[elementIndex];

            if (partitionsCount > word.Length)
            {
                return;
            }

            int partitionsLengh = word.Length / partitionsCount;
            int partitionsReminder = word.Length % partitionsCount;
            int lastPartitionsLengh = partitionsLengh + partitionsReminder;

            List<string> partitions = new List<string>();
            for (int i = 0; i < partitionsCount; i++)
            {
                char[] currentPartition;

                if (i == partitionsCount  - 1)
                {
                    currentPartition = word
                        .Skip(i * partitionsLengh)
                        .Take(lastPartitionsLengh)
                        .ToArray();
                }
                else
                {
                    currentPartition = word
                        .Skip(i * partitionsLengh)
                        .Take(partitionsLengh)
                        .ToArray();
                }
                partitions.Add((new string(currentPartition)));
            }
            words.RemoveAt(elementIndex);

            words.InsertRange(elementIndex, partitions);
        }
        static bool IsIndexValid(List<string> words, int index)
        {
            return index >= 0 && index < words.Count;
        }
    }
}