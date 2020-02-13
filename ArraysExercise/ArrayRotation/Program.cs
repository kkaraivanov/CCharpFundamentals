using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int numberOfRotatinon = int.Parse(Console.ReadLine());
            int[] newArr = new int[arr.Length];

            for (int i = 0; i < numberOfRotatinon % arr.Length; i++)
            {
                int element = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    newArr[j - 1] = arr[j];
                }
                newArr[arr.Length - 1] = element;
                arr = newArr;
            }

            foreach (var number in arr)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
