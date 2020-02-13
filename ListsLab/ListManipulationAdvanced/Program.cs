using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();
            string commands = string.Empty;
            bool chekChanges = false;
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] command = commands.Split().ToArray();
                int num = 0;

                switch (command[0])
                {
                    case "Add":
                        num = int.Parse(command[1]);
                        numbers.Add(num);
                        chekChanges = true;
                        break;
                    case "Remove":
                        num = int.Parse(command[1]);
                        numbers.Remove(num);
                        chekChanges = true;
                        break;
                    case "RemoveAt":
                        num = int.Parse(command[1]);
                        numbers.RemoveAt(num);
                        chekChanges = true;
                        break;
                    case "Insert":
                        num = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        numbers.Insert(index, num);
                        chekChanges = true;
                        break;
                    case "Contains":
                        num = int.Parse(command[1]);
                        Console.WriteLine(numbers.Contains(num) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(number => number % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(number => number % 2 != 0)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        string condition = command[1];
                        long number = long.Parse(command[2]);
                        Console.WriteLine(string.Join(" ", FilterNumbers(numbers, condition, number)));
                        break;
                }
            }

            if(chekChanges)
                Console.WriteLine(string.Join(" ", numbers));
        }
        static List<long> FilterNumbers(List<long> numbers, string condition, long number)
        {
            //'<', '>', ">=", "<="
            List<long> temp = new List<long>();
            switch (condition)
            {
                case "<":
                    temp = numbers.Where(num => num < number).ToList();
                    break;
                case ">":
                    temp = numbers.Where(num => num > number).ToList();
                    break;
                case "<=":
                    temp = numbers.Where(num => num <= number).ToList();
                    break;
                case ">=":
                    temp = numbers.Where(num => num >= number).ToList();
                    break;
            }

            return temp;
        }
    }
}
