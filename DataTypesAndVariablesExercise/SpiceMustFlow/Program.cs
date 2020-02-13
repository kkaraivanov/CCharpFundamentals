using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            const int peopleYeld = 26;
            int days = 0;
            int totalAmount = 0;

            for (int i = startingYield; i >= 100; i -= 10)
            {
                days++;
                totalAmount += i - peopleYeld;
                if (i - 10 < 100)
                {
                    totalAmount -= peopleYeld;
                }
            }
            Console.WriteLine(days);
            Console.WriteLine(totalAmount);
        }
    }
}
