namespace OddOccurrences
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
                .ToList();
            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word.ToLower()))
                    dict[word.ToLower()] = 0;

                dict[word.ToLower()]++;
            }

            Console.WriteLine(string.Join(" ", dict.Where(x => x.Value % 2 != 0).Select(x => x.Key)));
        }
    }
}
