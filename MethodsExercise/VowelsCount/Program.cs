using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Console.WriteLine(GetVowelsCount(line));
        }

        private static int GetVowelsCount(string line)
        {
            char[] vowels = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (line[i] == vowels[j])
                        count++;
                }
            }

            return count;
        }
    }
}