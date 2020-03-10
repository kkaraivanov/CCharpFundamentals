using System;
using System.Linq;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWord = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in bannedWord)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
