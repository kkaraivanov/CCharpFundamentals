using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            
            if (IsZero(a, b, c))
                Console.WriteLine("zero");
            else if (IsPositive(a,b,c) && !IsZero(a,b,c))
                Console.WriteLine("positive");
            if (!IsPositive(a, b, c) && !IsZero(a, b, c))
                Console.WriteLine("negative");
        }
        static bool IsZero(long a, long b, long c)
        {
            return a == 0 || b == 0 || c == 0 ? true : false;
        }
        static bool IsPositive(long a, long b, long c)
        {
            bool numA = a > 0 ? true : false;
            bool numB = b > 0 ? true : false;
            bool numC = c > 0 ? true : false;

            if (!numA && !numB & !numC)
                return false;
            else if (numA && numB & !numC)
                return false;
            else if (numA && !numB & numC)
                return false;
            else if (!numA && numB & numC)
                return false;

            return true;
        }
    }
}
