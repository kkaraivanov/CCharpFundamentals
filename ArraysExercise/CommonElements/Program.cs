﻿using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split()
                .ToArray();
            string[] arr2 = Console.ReadLine()
                .Split()
                .ToArray();
            string result = "";
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i].Equals(arr1[j]))
                    {
                        result += arr2[i] + " ";
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
