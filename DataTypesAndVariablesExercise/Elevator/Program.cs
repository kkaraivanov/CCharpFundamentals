using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            if (capacity >= peopleCount)
            {
                Console.WriteLine(1);
            }
            else
            {
                int result = 0;
                for (int i = 1; i <= peopleCount; i += capacity)
                {
                    result++;
                }
                Console.WriteLine(result);
            }
        }
    }
}
