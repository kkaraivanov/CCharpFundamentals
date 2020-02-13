using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());

            int[] ferstNumber = new int[line];
            int[] secondNumber = new int[line];
            for (int i = 0; i < line; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    ferstNumber[i] = input[0];
                    secondNumber[i] = input[1];
                }
                else
                {
                    ferstNumber[i] = input[1];
                    secondNumber[i] = input[0];
                }
            }

            for (int i = 0; i < ferstNumber.Length; i++)
            {
                Console.Write(ferstNumber[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < secondNumber.Length; i++)
            {
                Console.Write(secondNumber[i] + " ");
            }
        }
    }
}
