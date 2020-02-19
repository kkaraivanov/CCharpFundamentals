using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleCatalogue
{
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

        public string DisplayVehicleCatalog()
        {
            var tempCars = Cars.OrderBy(car => car.Brand).ToList();
            var tempTrucks = Trucks.OrderBy(truck => truck.Brand).ToList();
            var sb = new StringBuilder();

            if (Cars.Count > 0)
            {
                sb.AppendLine("Cars:");
                foreach (var car in tempCars)
                {
                    sb.AppendLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (Trucks.Count > 0)
            {
                sb.AppendLine("Trucks:");
                foreach (var truck in tempTrucks)
                {
                    sb.AppendLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

            return sb.ToString();
        }
    }
}
