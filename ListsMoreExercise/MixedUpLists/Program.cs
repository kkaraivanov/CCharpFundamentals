using System;
using System.Linq;
using System.Collections.Generic;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ferstNumbersLine = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumbersLine = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listWithAllElements = new List<int>();
            List<int> rangeElements = new List<int>();

            if (ferstNumbersLine.Count > secondNumbersLine.Count)
            {
                rangeElements = ferstNumbersLine.Skip(ferstNumbersLine.Count - 2).ToList();
                ferstNumbersLine.RemoveRange(ferstNumbersLine.Count - 2, 2);
            }
            else if (ferstNumbersLine.Count < secondNumbersLine.Count)
            {
                rangeElements = secondNumbersLine.Take(2).ToList();
                secondNumbersLine.RemoveRange(0, 2);
            }

            rangeElements.Sort();
            listWithAllElements = GetNewNumberList(ferstNumbersLine, secondNumbersLine);
            listWithAllElements = listWithAllElements.Where(x => x > rangeElements[0] && x < rangeElements[1]).ToList();
            listWithAllElements.Sort();

            Console.WriteLine(string.Join(" ", listWithAllElements));
        }

        private static List<int> GetNewNumberList(List<int> ferstNumbersLine, List<int> secondNumbersLine)
        {
            List<int> temp = new List<int>();
            secondNumbersLine.Reverse();
            
            for (int i = 0; i < ferstNumbersLine.Count; i++)
            {
                temp.Add(ferstNumbersLine[i]);
                temp.Add(secondNumbersLine[i]);
            }

            return temp;
        }
    }
}
