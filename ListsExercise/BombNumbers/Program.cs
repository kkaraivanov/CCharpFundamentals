using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split().Select(long.Parse).ToList();
            int[] bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

            TheBombExploding(numbers, bombAndPower[0], bombAndPower[1]);

            Console.WriteLine(string.Join(" ", numbers.Sum()));
        }

        private static void TheBombExploding(List<long> numbers, int theBomb, int power)
        {
            int bombIndex = numbers.FindIndex(i => i == theBomb);
            for (int i = 1; i <= power; i++)
            {
                if (bombIndex + 1 > numbers.Count - 1)
                    break;
                else
                    numbers.RemoveAt(bombIndex + 1);
            }
            for (int i = 1; i <= power; i++)
            {
                if (bombIndex - 1 < 0)
                    break;
                else
                {
                    numbers.RemoveAt(bombIndex - 1);
                    bombIndex--;
                }
            }

            numbers.RemoveAt(bombIndex);

            if (numbers.Contains(theBomb))
                TheBombExploding(numbers, theBomb, power);
        }
    }
}
