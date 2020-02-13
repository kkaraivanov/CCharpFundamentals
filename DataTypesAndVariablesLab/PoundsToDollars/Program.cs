using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            double dolarForPound = 1.31;

            Console.WriteLine("{0:f3}", pounds * (decimal)dolarForPound);
        }
    }
}
