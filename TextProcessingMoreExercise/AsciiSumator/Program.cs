using System;

namespace AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char ferst = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());
            string arr = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > ferst && last > arr[i])
                    result += arr[i];
            }

            Console.WriteLine(result);
        }
    }
}
