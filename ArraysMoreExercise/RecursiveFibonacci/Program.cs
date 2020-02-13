using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonachiNum = int.Parse(Console.ReadLine());

            Console.WriteLine(FibonachiRecursion(fibonachiNum));
        }
        static long FibonachiRecursion(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return FibonachiRecursion(n - 1) + FibonachiRecursion(n - 2);
        }
    }
}
