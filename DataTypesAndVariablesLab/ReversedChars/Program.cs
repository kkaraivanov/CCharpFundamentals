using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                char c = char.Parse(Console.ReadLine());
                result += c;
            }

            string printResult = string.Empty;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                printResult += result[i] + " ";
            }
            Console.WriteLine(printResult);
        }
    }
}
