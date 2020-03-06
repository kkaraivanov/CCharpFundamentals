namespace WordSynonyms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var words = new Dictionary<string, List<string>>();

            for (int i = 0; i < lines; i++)
            {
                string word = Console.ReadLine();
                string sinonimus = Console.ReadLine();

                if (!words.ContainsKey(word))
                    words[word] = new List<string>();

                words[word].Add(sinonimus);
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
