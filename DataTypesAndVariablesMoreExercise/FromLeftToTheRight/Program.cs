using System;
using System.Linq;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                for (int j = 0; j < numbers.Length; j++)
                {
                    decimal leftNumber = decimal.Parse(numbers[0]);
                    decimal rightNumber = decimal.Parse(numbers[1]);
                    if (leftNumber > rightNumber)
                    {
                        leftNumber = Math.Abs(leftNumber);
                        Console.WriteLine(Result(leftNumber.ToString()));
                        break;
                    }
                    else
                    {
                        rightNumber = Math.Abs(rightNumber);
                        Console.WriteLine(Result(rightNumber.ToString()));
                        break;
                    }
                }
            }
            static decimal Result(string number)
            {
                decimal result = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    result += decimal.Parse(number[i].ToString());
                }
                return result;
            }
        }
    }
}
