using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            
            for (int i = 0; i < lines; i++)
            {
                products.Add(Console.ReadLine());
            }
            
            lines = 1;
            products.Sort();
            products.ForEach(product => { Console.WriteLine($"{lines}.{product}"); lines++; });
        }
    }
}
