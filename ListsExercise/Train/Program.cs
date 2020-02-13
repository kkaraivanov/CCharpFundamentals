using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> wagons = Console.ReadLine().Split().Select(long.Parse).ToList();
            long maxPassgerInWagon = long.Parse(Console.ReadLine());
            string commands = null;

            while ((commands = Console.ReadLine()) != "end")
            {
                string[] command = commands.Split().ToArray();

                if(command[0] == "Add")
                {
                    long passager = long.Parse(command[1]);
                    AddNewWagon(wagons, passager, maxPassgerInWagon);
                }
                else if (long.TryParse(command[0], out long l))
                {
                    InsurtPassagerInWagon(wagons, l, maxPassgerInWagon);
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }

        private static void InsurtPassagerInWagon(List<long> wagons, long passager, long maxPassgerInWagon)
        {
            if (passager >= 0 && passager <= maxPassgerInWagon)
            {
                for (int i = 0; i < wagons.Count; i++)
                {
                    long currentPassager = wagons[i];
                    if (passager + currentPassager <= maxPassgerInWagon)
                    {
                        wagons[i] = passager + currentPassager;
                        break;
                    }
                }
            }
        }

        private static void AddNewWagon(List<long> wagons, long passager, long maxPassgerInWagon)
        {
            if (passager >= 0 && passager <= maxPassgerInWagon)
            {
                wagons.Add(passager);
            }
        }
    }
}
