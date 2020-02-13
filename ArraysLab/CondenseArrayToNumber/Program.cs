using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            while (true)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine($"{numbers[0]}");
                    break;
                }
                int[] result = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    result[i] = numbers[i] + numbers[i + 1];
                }
                
                if (result.Length == 1)
                {
                    Console.WriteLine($"{result[0]}");
                    break;
                }
                numbers = result;
            }
        }
    }
}
