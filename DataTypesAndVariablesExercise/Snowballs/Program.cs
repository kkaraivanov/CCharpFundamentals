using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger[] bestResult = { -1, 0, -1, 0 };

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine()); // index 0
                BigInteger snowballTime = BigInteger.Parse(Console.ReadLine()); // index 1
                int snowballQuality = int.Parse(Console.ReadLine());    // index 2

                BigInteger numberOfThrows = snowballSnow / snowballTime;
                BigInteger snowballValue = BigInteger.Pow(numberOfThrows, snowballQuality); // index 3
                
                if (bestResult[3] < snowballValue)
                {
                    bestResult[0] = snowballSnow;
                    bestResult[1] = snowballTime;
                    bestResult[2] = snowballQuality;
                    bestResult[3] = snowballValue;
                }
            }

            Console.WriteLine($"{bestResult[0]} : {bestResult[1]} = {bestResult[3]} ({bestResult[2]})");
        }
    }
}