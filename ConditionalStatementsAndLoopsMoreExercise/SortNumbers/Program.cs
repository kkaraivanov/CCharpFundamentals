using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            for (int i = 0; i < 3; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(number);
            Array.Reverse(number);
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
        }
    }
}
