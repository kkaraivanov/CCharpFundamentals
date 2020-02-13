using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long minNum = long.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                long num = long.Parse(Console.ReadLine());
                if (num < minNum)
                    minNum = num;
            }
            Console.WriteLine(minNum);
        }
    }
}
