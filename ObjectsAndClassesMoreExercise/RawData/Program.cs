using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var car = new Car();

            for (int i = 0; i < n; i++)
            {
                var engine = new Engine();
                var cargo = new Cargo();
                // "<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>
                string line = Console.ReadLine();
                engine.Speed = int.Parse(line.Split()[1]);
                engine.Power = int.Parse(line.Split()[2]);
                cargo.Weight = int.Parse(line.Split()[3]);
                cargo.Type = line.Split()[4];

                car.Add(line.Split()[0], engine, cargo);
            }

            car.DisplayCarType(Console.ReadLine());
        }
    }
}
