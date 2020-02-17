using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //BigInteger factorial = n;
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    factorial = factorial * i;
            //}
            //Console.WriteLine(factorial);

            Console.WriteLine(Factorial(n));
        }

        private static BigInteger Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
