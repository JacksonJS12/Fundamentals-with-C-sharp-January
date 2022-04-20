using System;
using System.Collections.Generic;
using System.Text;

namespace MoreExerciseP01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());

            int vowelSum = 0;
            int consonantSum = 0;

            List<int> numberOfSequences = new List<int>();
            for (int j = 0; j < numberOfStrings; j++)
            {
                string sequences = Console.ReadLine();

                var vowelValue = Encoding.ASCII.GetBytes(sequences);
                for (int i = 0; i < sequences.Length; i++)
                {

                    //The code of each vowel multiplied by the string length
                    if (sequences[i] == 'a' || sequences[i] == 'e' ||
                        sequences[i] == 'i' || sequences[i] == 'o' ||
                        sequences[i] == 'u' || sequences[i] == 'A' ||
                        sequences[i] == 'E' || sequences[i] == 'I' ||
                        sequences[i] == 'O' || sequences[i] == 'U')
                    {
                        vowelSum += vowelValue[i] * sequences.Length;
                    }
                    else
                    {
                        //The code of each consonant divided by the string length
                        consonantSum += vowelValue[i] / sequences.Length;
                    }

                }

                numberOfSequences.Add(vowelSum + consonantSum);
                vowelSum = 0;
                consonantSum = 0;


            }
            numberOfSequences.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, numberOfSequences));
        }
    }
}
