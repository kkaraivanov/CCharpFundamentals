using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] centerArray = new int[num.Length / 2];
            int[] resultArray = new int[num.Length / 2];
            int[] leftArray = new int[num.Length / 4];
            int[] rightArray = new int[num.Length / 4];

            for (int i = 0; i < num.Length; i++)
            {
                if (i >= 0 && i < num.Length / 4)
                    leftArray[i] = num[i];
                else if (i >= leftArray.Length && i < leftArray.Length + centerArray.Length)
                    centerArray[i - leftArray.Length] = num[i];
                else if (i >= leftArray.Length + centerArray.Length && i != num.Length)
                    rightArray[i - (leftArray.Length + centerArray.Length)] = num[i];
            }
            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            for (int i = 0; i < centerArray.Length; i++)
            {
                if (i >= 0 && i < centerArray.Length / 2)
                    resultArray[i] = leftArray[i] + centerArray[i];
                else
                    resultArray[i] = rightArray[i - centerArray.Length / 2] + centerArray[i];
            }

            Console.Write(string.Join(" ", resultArray));
            Console.WriteLine();
        }
    }
}
