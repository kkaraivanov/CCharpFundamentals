using System;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split();
            var sb = new StringBuilder();

            foreach (var item in line)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    sb.Append(item);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
