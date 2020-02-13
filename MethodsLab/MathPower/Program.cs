using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(GetPower(num, power));
        }

        private static decimal GetPower(double num, double power)
        {
            decimal result = 0;

            result = (decimal)Math.Pow(num, power);
            return result;
        }
    }
}