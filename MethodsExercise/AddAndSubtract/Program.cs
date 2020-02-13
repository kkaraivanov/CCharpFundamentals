using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            long ferstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());
            long threeNum = long.Parse(Console.ReadLine());

            Console.WriteLine(Result(ferstNum, secondNum, threeNum));
        }

        private static long Result(long ferstNum, long secondNum, long threeNum)
        {
            long sum = ferstNum + secondNum;
            
            return Subtract(sum, threeNum);
        }

        private static long Subtract(long sum, long threeNum)
        {
            return sum - threeNum;
        }
    }
}
