using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char c = (char)('a' + i);
                        char cc = (char)('a' + j);
                        char ccc = (char)('a' + k);
                        Console.WriteLine("{0}{1}{2}", c, cc, ccc);
                    }
                }
            }
        }
    }
}
