using System;
using System.Globalization;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string dateFormat = "d/M/yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime dt = DateTime.ParseExact(line.Replace('-', '/'), dateFormat, provider);
            
            Console.WriteLine(dt.DayOfWeek.ToString());
        }
    }
}
