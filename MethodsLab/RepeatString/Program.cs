using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string lethers = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintResult(lethers, lines));
        }

        private static string PrintResult(string lethers, int lines)
        {
            string result = string.Empty;
            for (int i = 0; i < lines; i++)
            {
                result += lethers;
            }
            return result;
        }
    }
}
