using System;

namespace CharsToString
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
            Console.WriteLine(result);
        }
    }
}
