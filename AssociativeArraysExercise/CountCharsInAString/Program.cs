namespace CountCharsInAString
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
                .ToArray();
            var dict = new Dictionary<char, int>();

            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (!dict.ContainsKey(word[i]))
                        dict[word[i]] = 0;

                    dict[word[i]]++;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
