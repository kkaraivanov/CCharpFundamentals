using System;
using System.Collections.Generic;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long a = 0;
            long b = 0;
            long c = 1;
            long d = a + b + c;
            List<long> tribonacciSequence = new List<long>();
            tribonacciSequence.Add(d);
            //Console.Write($"{d} ");

            for (int i = 1; i < n; i++)
            {
                //Console.Write($"{d} ");
                tribonacciSequence.Add(d);
                a = b;
                b = c;
                c = d;
                d = a + b + c;
            }

            Console.WriteLine(string.Join(" ",tribonacciSequence));
        }
    }
}
