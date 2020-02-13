﻿using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] numbers2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers1[i] != numbers2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                    sum += numbers1[i];
                if (i == numbers1.Length - 1)
                {
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                    break;
                }
            }
        }
    }
}
