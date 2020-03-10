using System;
using System.Collections.Generic;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new List<string>();
            text.Add(Console.ReadLine());
            text.Add(Console.ReadLine());
            string comments = Console.ReadLine();

            while (true)
            {
                if (comments == "end of comments")
                    break;
                text.Add(comments);
                comments = Console.ReadLine();
            }

            Console.WriteLine($"<h1>{Environment.NewLine}\t{text[0]}{Environment.NewLine}</h1>");
            Console.WriteLine($"<article>{Environment.NewLine}\t{text[1]}{Environment.NewLine}</article>");
            for (int i = 2; i < text.Count; i++)
            {
                Console.WriteLine($"<div>{Environment.NewLine}\t{text[i]}{Environment.NewLine}</div>");
            }
        }
    }
}
