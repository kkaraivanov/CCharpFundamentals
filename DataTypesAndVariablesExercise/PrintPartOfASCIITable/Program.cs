using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string print = string.Empty;
            for (int i = start; i <= end; i++)
            {
                char c = Convert.ToChar(i);
                print += c + " ";
            }
            Console.WriteLine(print);
        }
    }
}
