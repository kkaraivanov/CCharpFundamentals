using System;
using System.Linq;

namespace EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            string[] arrayWithLineWords = new string[line];
            char[] vowelsLetters = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < line; i++)
            {
                arrayWithLineWords[i] = Console.ReadLine();
            }

            int[] print = new int[line];
            for (int i = 0; i < arrayWithLineWords.Length; i++)
            {
                int sumVowels = 0;
                int sumConsonant = 0;
                string currentWordFromArray = arrayWithLineWords[i];
                for (int j = 0; j < currentWordFromArray.Length; j++)
                {
                    if (vowelsLetters.Contains(currentWordFromArray[j]))
                    {
                        sumVowels += currentWordFromArray[j] * currentWordFromArray.Length;
                    }
                    else
                    {
                        sumConsonant += currentWordFromArray[j] / currentWordFromArray.Length;
                    }
                }
                print[i] = sumVowels + sumConsonant;
            }
            Array.Sort(print);
            Console.WriteLine(string.Join("\n", print));
        }
    }
}