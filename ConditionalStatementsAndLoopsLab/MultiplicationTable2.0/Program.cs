using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int startPoint = int.Parse(Console.ReadLine());

            if (startPoint > 0 && startPoint <= 10)
            {
                for (int i = startPoint; i <= 10; i++)
                {
                    Console.WriteLine($"{input} X {i} = {input * i}");
                }
            }
            else
            {
                Console.WriteLine($"{input} X {startPoint} = {input * startPoint}");
            }
        }
    }
}
