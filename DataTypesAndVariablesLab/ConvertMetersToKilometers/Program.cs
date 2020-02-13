using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kilometers = 0;
            kilometers = (decimal)meters / 1000;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
