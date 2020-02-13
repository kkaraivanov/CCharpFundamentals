using System;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuryes = int.Parse(Console.ReadLine());

            var totalYears = centuryes * 100;
            var totalDay = Math.Floor(totalYears * 365.2422);
            var totalHours = Math.Floor(totalDay * 24);
            var totalMinutes = totalHours * 60;
            
            Console.WriteLine($"{centuryes} centuries = {totalYears} years = {totalDay} days = {totalHours} hours = {totalMinutes} minutes");
        }
    }
}