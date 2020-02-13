using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStart = int.Parse(Console.ReadLine());
            int numberEnd = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = numberStart; i <= numberEnd; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
