using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            double minValue = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                string modelKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                uint height = uint.Parse(Console.ReadLine());
                double value = Math.PI * (radius * radius) * height;
                if (minValue < value)
                {
                    minValue = value;
                    result = $"{modelKeg}";
                }
                else
                    continue;
            }
            Console.WriteLine(result);
        }
    }
}
