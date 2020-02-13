using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ferstNumber = decimal.Parse(Console.ReadLine());
            char charOperator = char.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            decimal result = Calculate(ferstNumber, charOperator, secondNumber);
            Console.WriteLine($"{result}");
        }

        private static decimal Calculate(decimal ferstNumber, char charOperator, decimal secondNumber)
        {
            decimal result = 0;
            switch (charOperator)
            {
                case '+':
                    result = ferstNumber + secondNumber;
                    break;
                case '-':
                    result = Math.Abs(ferstNumber - secondNumber);
                    break;
                case '*':
                    result = ferstNumber * secondNumber;
                    break;
                case '/':
                    result = secondNumber == 0 ? secondNumber / ferstNumber : ferstNumber / secondNumber;
                    break;
            }

            return result;
        }
    }
}
