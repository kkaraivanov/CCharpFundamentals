using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i <= numbers.Count; i++)
            {
                int ferstNum = i;
                int lastNum = numbers.Count - 1;
                if (ferstNum >= lastNum)
                    break;
                double sum = numbers[ferstNum] + numbers[lastNum];
                numbers[ferstNum] = sum;
                numbers.RemoveAt(lastNum);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
