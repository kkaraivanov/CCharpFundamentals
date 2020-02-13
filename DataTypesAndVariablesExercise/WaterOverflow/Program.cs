using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int capacity = 255;
            int line = int.Parse(Console.ReadLine());
            double litersInTheTank = 0;

            for (int i = 0; i < line; i++)
            {
                int quantitiesWater = int.Parse(Console.ReadLine());
                if (litersInTheTank + quantitiesWater > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                    litersInTheTank += quantitiesWater;
            }
            Console.WriteLine(litersInTheTank);
        }
    }
}
