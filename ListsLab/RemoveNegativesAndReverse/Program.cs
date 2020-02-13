using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> elements = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            elements = elements.Where(i => i > 0).ToList();

            if (elements.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            elements.Reverse();
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
