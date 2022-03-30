using System;

namespace P06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetRectangleArea(width, height);
            Console.Write(area);
        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
