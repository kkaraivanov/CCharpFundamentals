using System;
using System.Linq;
using System.Collections.Generic;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineTime = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            double leftCarTime = LeftCarTime(lineTime);
            lineTime.Reverse();
            double rightCarTime = RightCarTime(lineTime);
            
            if (leftCarTime < rightCarTime)
                DisplayWinner("left", leftCarTime);
            else
                DisplayWinner("right", rightCarTime);
        }

        private static void DisplayWinner(string car, double carTime)
        {
            Console.WriteLine($"The winner is {car} with total time: {carTime}");
        }

        private static double LeftCarTime(List<int> rangeArray)
        {
            return GetTime(rangeArray);
        }

        private static double RightCarTime(List<int> rangeArray)
        {
            return GetTime(rangeArray);
        }

        private static double GetTime(List<int> rangeArray)
        {
            double temp = 0.0;
            for (int i = 0; i < rangeArray.Count / 2; i++)
            {
                if (rangeArray[i] == 0)
                    temp = temp * 8 / 10;
                else
                    temp += rangeArray[i];
            }

            return temp;
        }
    }
}
