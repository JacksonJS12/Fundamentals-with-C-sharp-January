using System;
using System.Text;

namespace P07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string template = Console.ReadLine();
            int repeatTimes = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(template, repeatTimes));
            
        }

        static string RepeatString(string template, int numOfRepates)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < numOfRepates; i++)
            {
                stringBuilder.Append(template);
            }

            return stringBuilder.ToString();
        }
    }
}
