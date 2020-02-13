using System;
using System.Text;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintResult(num));
        }

        private static string PrintResult(int num)
        {
            StringBuilder printResult = new StringBuilder($"The number {num} is ");
            if (num > 0)
                printResult.Append("positive.");
            else if (num < 0)
                printResult.Append("negative.");
            else
                printResult.Append("zero.");

            return printResult.ToString();
        }
    }
}
