using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
        // model, fuel amount, fuel consumption per kilometer and traveled distance
        // model is unique
        private List<Car> Cars = new List<Car>();
        private string Model { get; set; }
        private decimal FuelAmount { get; set; }
        private decimal FCPerK { get; set; }
        private long TraveledDistance { get; set; }

        public void AddNewCar(string v)
        {
            // < Model > < FuelAmount > < FuelConsumptionFor1km >
            Car car = new Car();
            if (!Cars.Select(x => x.Model).Contains(v.Split()[0]))
            {
                car.Model = v.Split()[0];
                car.FuelAmount = decimal.Parse(v.Split()[1]);
                car.FCPerK = decimal.Parse(v.Split()[2]);
                Cars.Add(car);
            }
        }

        public void Drive(string model, long amountOfKm)
        {
            Car car = new Car();
            var consumption = Cars.Where(x => x.Model == model).Select(x => x.FCPerK).ToList()[0];
            var fuelAmount = Cars.Where(x => x.Model == model).Select(x => x.FuelAmount).ToList()[0];
            var trevaled = Cars.Where(x => x.Model == model).Select(x => x.TraveledDistance).ToList()[0];
            var carIndex = Cars.FindIndex(c => c.Model == model);

            var needFuel = amountOfKm * consumption;
            if (fuelAmount >= needFuel)
            {
                car.Model = model;
                car.FuelAmount = fuelAmount - needFuel;
                car.FCPerK = consumption;
                car.TraveledDistance = trevaled + amountOfKm;
                Cars.RemoveAt(carIndex);
                Cars.Insert(carIndex, car);
            }
            else
                Console.WriteLine("Insufficient fuel for the drive");
        }

        public void DisplayCarInformation()
        {
            // <Model> <fuelAmount> <distanceTraveled>
            var result = string.Empty;
            foreach (var car in Cars)
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
        }
    }
}
