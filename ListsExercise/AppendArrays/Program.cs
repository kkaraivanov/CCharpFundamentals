using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lineNumbersArray = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            for (int i = 0; i < lineNumbersArray.Count; i++)
            {
                List<string> tempArrayNumbers = lineNumbersArray[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                for (int j = 0; j < tempArrayNumbers.Count; j++)
                {
                    Console.Write($"{tempArrayNumbers[j]} ");
                }
            }
        }
    }
}
