using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int result = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        continue;
                    }
                    else if (arr[i] < arr[j])
                    {
                        result = 0;
                        break;
                    }
                    else
                        result = arr[i];
                }
                if (result != 0)
                {
                    Console.Write(result + " ");
                }
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
