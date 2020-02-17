using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split().ToArray();
            DisplayWordsFromText(line);
        }

        private static string GetRandomWord(string[] lineOfWord)
        {
            Random rand = new Random();
            int step = rand.Next(lineOfWord.Length);
            
            return lineOfWord[step];
        }

        private static void DisplayWordsFromText(string[] line)
        {
            List<string> temp = new List<string>();

            for (int i = 0; i < line.Length; i++)
            {
                string word = GetRandomWord(line);
                if (!temp.Contains(word))
                {
                    temp.Add(word);
                    Console.WriteLine(word);
                }
                else
                    i--;
            }
        }
    }
}
