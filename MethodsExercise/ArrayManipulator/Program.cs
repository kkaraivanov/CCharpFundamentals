using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class program
    {
        static void Main()
        {
            List<int> lineNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string inputCommand = string.Empty;

            while ((inputCommand = Console.ReadLine()) != "end")
            {
                List<string> command = inputCommand.Split().ToList();
                switch (command[0])
                {
                    case "exchange":
                        lineNumbers = Exchange(lineNumbers, command);
                        break;
                    case "max":
                        int indexPostion = FindMaxIndex(lineNumbers, command[1]);
                        DisplayIndexPosition(indexPostion);
                        break;
                    case "min":
                        indexPostion = FindMinIndex(lineNumbers, command[1]);
                        DisplayIndexPosition(indexPostion);
                        break;
                    case "first":
                        PrintFirstElements(lineNumbers, command);
                        break;
                    case "last":
                        PrintLastElements(lineNumbers, command);
                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", lineNumbers)}]");
        }

        private static void PrintFirstElements(List<int> lineNumbers, List<string> command)
        {
            int count = int.Parse(command[1]);

            if (count > lineNumbers.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> result = CreateEvenOrOddList(lineNumbers, command[2]);
                if (result.Count > count)
                {
                    result = result.Take(count).ToList();
                }

                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }

        private static void PrintLastElements(List<int> lineNumbers, List<string> command)
        {
            int count = int.Parse(command[1]);

            if (count > lineNumbers.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> result = CreateEvenOrOddList(lineNumbers, command[2]);
                if (result.Count > count)
                {
                    result = result.Skip(result.Count - count).ToList();
                }

                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }

        private static void DisplayIndexPosition(int indexPostion)
        {
            if (indexPostion != -1)
            {
                Console.WriteLine(indexPostion);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static int FindMinIndex(List<int> lineNumbers, string type)
        {
            int minOddValue = int.MaxValue;
            int minEvenValue = int.MaxValue;

            for (int i = 0; i < lineNumbers.Count; i++)
            {
                if (lineNumbers[i] % 2 != 0 && lineNumbers[i] <= minOddValue)
                {
                    minOddValue = lineNumbers[i];
                }
                else if (lineNumbers[i] % 2 == 0 && lineNumbers[i] <= minEvenValue)
                {
                    minEvenValue = lineNumbers[i];
                }
            }

            if (type == "odd")
            {
                int minOddIndex = lineNumbers.LastIndexOf(minOddValue);
                return minOddIndex;
            }
            else
            {
                int minEvenIndex = lineNumbers.LastIndexOf(minEvenValue);
                return minEvenIndex;
            }
        }

        private static int FindMaxIndex(List<int> lineNumbers, string type)
        {
            int maxOddValue = int.MinValue;
            int maxEvenValue = int.MinValue;

            for (int i = 0; i < lineNumbers.Count; i++)
            {
                if (lineNumbers[i] % 2 != 0 && lineNumbers[i] >= maxOddValue)
                {
                    maxOddValue = lineNumbers[i];
                }
                else if (lineNumbers[i] % 2 == 0 && lineNumbers[i] >= maxEvenValue)
                {
                    maxEvenValue = lineNumbers[i];
                }
            }

            if (type == "odd")
            {
                int maxOddIndex = lineNumbers.LastIndexOf(maxOddValue);
                return maxOddIndex;
            }
            else
            {
                int maxEvenIndex = lineNumbers.LastIndexOf(maxEvenValue);
                return maxEvenIndex;
            }

        }

        private static List<int> Exchange(List<int> lineNumbers, List<string> command)
        {
            int index = int.Parse(command[1]);

            if (ValidateIndex(lineNumbers, index))
            {
                IEnumerable<int> firstPatch = lineNumbers.Take(index + 1);
                IEnumerable<int> secondPatch = lineNumbers.Skip(index + 1);
                lineNumbers = secondPatch.Concat(firstPatch).ToList();
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

            return lineNumbers;
        }

        private static List<int> CreateEvenOrOddList(List<int> inputList, string valueType)
        {
            if (valueType == "odd")
            {
                List<int> oddList = inputList.Where(x => x % 2 != 0).ToList();
                return oddList;
            }
            else
            {
                List<int> evenList = inputList.Where(x => x % 2 == 0).ToList();
                return evenList;
            }
        }
        private static bool ValidateIndex(List<int> lineNumbers, int index)
        {
            return index >= 0 && index < lineNumbers.Count;
        }
    }
}