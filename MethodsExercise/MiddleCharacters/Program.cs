using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            Console.WriteLine(Result(line));
        }

        private static string Result(string line)
        {
            string result = string.Empty;
            if (line.Length % 2 == 0)
                result = line.Substring(line.Length / 2 - 1, 2);
            else
                result = line.Substring(line.Length / 2, 1);

            return result;
        }
    }
}
