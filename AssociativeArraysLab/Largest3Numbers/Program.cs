namespace Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            numbers = numbers.OrderByDescending(n => n).ToArray();

            Console.WriteLine(numbers.Length >= 3 ?
                string.Join(" ", numbers.Take(3)) :
                string.Join(" ", numbers));
        }
    }
}
