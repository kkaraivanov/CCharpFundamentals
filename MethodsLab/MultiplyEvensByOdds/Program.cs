using System;
using System.Linq;
using System.Collections.Generic;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            GetMultipleOfEvenAndOdds(number);
        }

        private static void GetMultipleOfEvenAndOdds(long num)
        {
            string number = num < 0 ? Math.Abs(num).ToString() : num.ToString();
            long evenNumber = GetSumOfEvenDigits(number);
            long oddNumber = GetSumOfOddDigits(number);

            Console.WriteLine($"{evenNumber * oddNumber}");
        }
        private static long GetSumOfEvenDigits(string num)
        {
            List<long> number = new List<long>();
            for (int i = 0; i < num.Length; i++)
            {
                if(num[i] % 2 == 0)
                    number.Add(int.Parse(num[i].ToString()));
            }

            return number.Sum();
        }
        private static long GetSumOfOddDigits(string num)
        {
            List<long> number = new List<long>();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 != 0)
                    number.Add(int.Parse(num[i].ToString()));
            }

            return number.Sum();
        }
    }
}
