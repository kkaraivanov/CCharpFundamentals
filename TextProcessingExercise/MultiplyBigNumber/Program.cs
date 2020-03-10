using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multi = int.Parse(Console.ReadLine());

            number = number.TrimStart('0');
            if(multi == 0)
            {
                Console.WriteLine("0");
                return;
            }

            var colectionNums = new Stack<string>();
            int temp = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                temp = int.Parse(Convert.ToString(number[i])) * multi + temp;
                colectionNums.Push((temp % 10).ToString());
                temp /= 10;
            }
            
            if(temp > 0)
                Console.WriteLine($"{temp}{string.Join("", colectionNums)}");
            else
                Console.WriteLine($"{string.Join("", colectionNums)}");
        }
    }
}
