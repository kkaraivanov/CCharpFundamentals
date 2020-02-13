using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            for (long i = 1; i <= num; i++)
                GetSum(i);
                    
        }

        private static void GetSum(long l)
        {
            long sum = 0;
            long printNum = l;
            bool setOddNumber = false;

            while (l > 0)
            {
                if (l == 0)
                    break;
                long temp = l % 10;
                sum += temp;
                if (!(temp % 2 == 0))
                    setOddNumber = true;
                l /= 10;
            }

            if (sum % 8 == 0 && setOddNumber)
            {
                Console.WriteLine(printNum);
            }
        }
    }
}
