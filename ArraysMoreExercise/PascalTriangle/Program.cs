using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            int paskalValue = 1;

            for (int i = 0; i < line; i++)
            {
                if (i == 0)
                    Console.Write(1);
                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || i == 0)
                        paskalValue = 1;
                    else
                        paskalValue = paskalValue * (i - j + 1) / j;
                    Console.Write(paskalValue + " ");
                }
                if(i > 0)
                    Console.Write(1);
                Console.WriteLine();
            }
        }
    }
}
