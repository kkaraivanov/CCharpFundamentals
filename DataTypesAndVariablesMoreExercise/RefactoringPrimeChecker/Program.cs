using System;

namespace RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            for (int divider = 2; divider <= line; divider++)
            {
                bool chekState = true;
                for (int divisible = 2; divisible < divider; divisible++)
                {
                    if (divider % divisible == 0)
                    {
                        chekState = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", divider, chekState.ToString().ToLower());
            }

        }
    }
}
