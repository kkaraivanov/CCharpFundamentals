using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Catalog catalog = new Catalog();

            while ((input = Console.ReadLine()) != "end")
            {
                catalog.AddVehicleToCatalog(input);
            }

            catalog.DisplayVehicleCatalog();
        }
    }

    class Catalog
    {
        private List<Truck> Trucks { get; set; } = new List<Truck>();
        private List<Car> Cars { get; set; } = new List<Car>();
        public void AddVehicleToCatalog(string vehicle)
        {
            Truck truck = new Truck();
            Car car = new Car();
            Catalog catalog = new Catalog();
            switch (vehicle.Split('/')[0])
            {
                case "Truck":
                    truck.Brand = vehicle.Split('/')[1];
                    truck.Model = vehicle.Split('/')[2];
                    truck.Weight = int.Parse(vehicle.Split('/')[3]);
                    Trucks.Add(truck);
                    break;
                case "Car":
                    car.Brand = vehicle.Split('/')[1];
                    car.Model = vehicle.Split('/')[2];
                    car.HorsePower = int.Parse(vehicle.Split('/')[3]);
                    Cars.Add(car);
                    break;
            }
        }

        public void DisplayVehicleCatalog()
        {
            var tempCars = Cars.OrderBy(car => car.Brand).ToList();
            var tempTrucks = Trucks.OrderBy(truck => truck.Brand).ToList();

            if (Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in tempCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in tempTrucks)
                    {
                        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                    }
            }
        }
    }

    class Truck
    {
        // Brand, Model and Weight
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        // Brand, Model and Horse Power
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
}
