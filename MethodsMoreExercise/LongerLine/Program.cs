using System;
using System.Linq;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputLine = new double[8];
            for (int i = 0; i < inputLine.Length; i++)
            {
                inputLine[i] = double.Parse(Console.ReadLine());
            }
            
            DisplayResult(inputLine);
        }

        private static void DisplayResult(double[] inputLine)
        {
            double lineOne = GetLineLenght(inputLine[0], inputLine[1], inputLine[2], inputLine[3]);
            double lineTwo = GetLineLenght(inputLine[4], inputLine[5], inputLine[6], inputLine[7]);
            
            if(lineOne >= lineTwo && CheckDistanceToZero(inputLine[0], inputLine[1], inputLine[2], inputLine[3]))
                Console.WriteLine($"({inputLine[0]}, {inputLine[1]})({inputLine[2]}, {inputLine[3]})");
            else if (lineOne >= lineTwo && !CheckDistanceToZero(inputLine[0], inputLine[1], inputLine[2], inputLine[3]))
                Console.WriteLine($"({inputLine[2]}, {inputLine[3]})({inputLine[0]}, {inputLine[1]})");
            else if (lineOne < lineTwo && CheckDistanceToZero(inputLine[4], inputLine[5], inputLine[6], inputLine[7]))
                Console.WriteLine($"({inputLine[4]}, {inputLine[5]})({inputLine[6]}, {inputLine[7]})");
            else if (lineOne < lineTwo && !CheckDistanceToZero(inputLine[4], inputLine[5], inputLine[6], inputLine[7]))
                Console.WriteLine($"({inputLine[6]}, {inputLine[7]})({inputLine[4]}, {inputLine[5]})");
        }

        private static double GetLineLenght(double x1, double y1, double x2, double y2)
        {
            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            return result;
        }
        private static bool CheckDistanceToZero(double x1, double y1, double x2, double y2)
        {
            bool checkResult = false;
            double distanceOne = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double distanceTwo = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            
            if (distanceOne <= distanceTwo)
                checkResult = true;

            return checkResult;
        }
    }
}
