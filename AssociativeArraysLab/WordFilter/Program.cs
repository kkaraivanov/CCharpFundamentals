namespace WordFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToArray();
            Console.WriteLine(string.Join($"{Environment.NewLine}",words));
        }
    }
}
