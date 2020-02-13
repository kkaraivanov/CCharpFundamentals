using System;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal number = decimal.Parse(Console.ReadLine());
            decimal result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += number;
                if (i == n)
                    break;
                else
                    number = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(result);
        }
    }
}
