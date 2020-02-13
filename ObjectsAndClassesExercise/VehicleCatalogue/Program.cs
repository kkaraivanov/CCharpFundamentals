using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CatalogVehicle
{
    class Program
    {
        static void Main()
        {
            string lineOfCommands = string.Empty;
            Catalog catalogVehicles = new Catalog();

            while ((lineOfCommands = Console.ReadLine()) != "End")
            {
                string[] command = lineOfCommands.Split();
                string type = command[0];
                string model = command[1];
                string color = command[2];
                long horsepower = long.Parse(command[3]);
                catalogVehicles.Add(type, model, color, horsepower);
            }

            while ((lineOfCommands = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(catalogVehicles.GetModelInformation(lineOfCommands));
            }

            catalogVehicles.DisplayAverage();
        }
    }
    class Catalog
    {
        private List<Car> NewCar { get; set; }
        private List<Truck> NewTruck { get; set; }
        public Catalog() { this.NewTruck = new List<Truck>(); this.NewCar = new List<Car>(); }
        public void Add(string type, string model, string color, long horsepower)
        {
            switch (type)
            {
                case "car":
                    var car = new Car();
                    car.Model = model;
                    car.Color = color;
                    car.Horsepower = horsepower;
                    NewCar.Add(car);
                    break;
                case "truck":
                    var truck = new Truck();
                    truck.Model = model;
                    truck.Color = color;
                    truck.Horsepower = horsepower;
                    NewTruck.Add(truck);
                    break;
            }
        }
        public void DisplayAverage()
        {
            if (NewCar.Count > 0)
                Console.WriteLine($"Cars have average horsepower of: {(NewCar.Sum(nc => nc.Horsepower) / (NewCar.Count * 1.0)):f2}.");
            else
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");

            if (NewTruck.Count > 0)
                Console.WriteLine($"Trucks have average horsepower of: {(NewTruck.Sum(nt => nt.Horsepower) / (NewTruck.Count * 1.0)):f2}.");
            else
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
        }
        public string GetModelInformation(string model)
        {
            StringBuilder sb = new StringBuilder();
            if (NewCar.Count != 0)
            {
                foreach (var car in NewCar.Where(nc => nc.Model == model))
                {
                    sb.Append("Type: Car\n");
                    sb.Append($"Model: {car.Model}\n");
                    sb.Append($"Color: {car.Color}\n");
                    sb.Append($"Horsepower: {car.Horsepower}");
                }
            }
            if (NewTruck.Count != 0)
            {
                foreach (var truck in NewTruck.Where(nt => nt.Model == model))
                {
                    sb.Append("Type: Truck\n");
                    sb.Append($"Model: {truck.Model}\n");
                    sb.Append($"Color: {truck.Color}\n");
                    sb.Append($"Horsepower: {truck.Horsepower}");
                }
            }

            return sb.ToString();
        }
    }

    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public long Horsepower { get; set; }
    }

    class Truck
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public long Horsepower { get; set; }
    }
}