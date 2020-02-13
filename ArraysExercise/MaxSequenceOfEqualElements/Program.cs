using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int starttIndex = 0;
            int endIndex = 0;
            int equalMaxElements = int.MinValue;
            for (int i = 0; i < line.Length; i++)
            {
                int equalElements = 1;
                for (int j = i + 1; j < line.Length; j++)
                {
                    if (line[j] != line[i])
                    {
                        break;
                    }
                    else if (line[j] == line[i])
                    {
                        equalElements++;
                    }
                }
                if (equalElements != 1 && equalElements > equalMaxElements)
                {
                    equalMaxElements = equalElements;
                    starttIndex = i;
                    endIndex = i + (equalElements - 1);
                    i = endIndex;

                    if (i == line.Length)
                    {
                        break;
                    }
                }
            }
            for (int i = starttIndex; i <= endIndex; i++)
            {
                Console.Write(line[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
