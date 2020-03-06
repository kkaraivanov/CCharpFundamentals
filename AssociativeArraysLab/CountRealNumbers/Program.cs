namespace CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var numbers = new SortedDictionary<double,int>();

            foreach (var number in line)
            {
                if (!numbers.ContainsKey(number))
                    numbers[number] = 0;

                numbers[number]++;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
