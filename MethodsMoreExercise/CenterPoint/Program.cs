using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //d = Math.Sqrt(Math.Sqrt(x2 - x1) + Math.Sqrt(y2 - y1))
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
           
            DisplayCenter(x1, y1, x2, y2);
        }
        private static void DisplayCenter(double x1, double y1, double x2, double y2)
        {
            double result1 = Math.Sqrt(Math.Abs(x1) + Math.Abs(y1));
            double result2 = Math.Sqrt(Math.Abs(x2) + Math.Abs(y2));

            if (result1 == 0)
                Console.WriteLine($"({x1}, {y1})");
            else if (result2 == 0)
                Console.WriteLine($"({x2}, {y2})");
            else if (result1 < result2)
                Console.WriteLine($"({x1}, {y1})");
            else if (result1 > result2)
                Console.WriteLine($"({x2}, {y2})");
            else
                Console.WriteLine($"({x1}, {y1})");
        }
    }
}
