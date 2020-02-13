using System;

namespace Divison
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] division = { 10, 7, 6, 3, 2 };
            int result = 0;
            for (int i = 0; i < division.Length; i++)
            {
                if (number % division[i] == 0)
                {
                    result = division[i];
                    break;
                }
            }
            Console.WriteLine(result != 0 ? $"The number is divisible by {result}" : "Not divisible");
        }
    }
}
