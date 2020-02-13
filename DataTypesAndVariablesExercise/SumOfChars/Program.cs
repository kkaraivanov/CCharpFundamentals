using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < line; i++)
            {
                char c = char.Parse(Console.ReadLine());
                result += c;
            }
            Console.WriteLine($"The sum equals: {result}");
        }
    }
}
