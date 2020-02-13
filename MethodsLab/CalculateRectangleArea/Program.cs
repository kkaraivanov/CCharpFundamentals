using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(Area(a, h).ToString());
        }

        static double Area(double a, double h)
        {
            return a * h;
        }
    }
}
