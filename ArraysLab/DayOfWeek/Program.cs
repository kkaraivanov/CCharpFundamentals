using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDay = int.Parse(Console.ReadLine());
            string[] weekDay = { "Invalid day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine(numberDay < weekDay.Length && numberDay >= 0 ? $"{weekDay[numberDay]}" : $"{weekDay[0]}");
        }
    }
}
