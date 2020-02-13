using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool chekBreak = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                chekBreak = false;
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    break;
                }

                int leftSum = 0;
                int rightSum = 0;
                for (int k = 0; k < i; k++)
                {
                    leftSum += numbers[k];
                }
                for (int j = 1 + i; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                if (leftSum != rightSum)
                {
                    chekBreak = true;
                }
                else if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            if (chekBreak)
            {
                Console.WriteLine("no");
            }
        }
    }
}
