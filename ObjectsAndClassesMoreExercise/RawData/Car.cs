using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RawData
{
    class Car
    {
        // model, engine and cargo
        // The Engine and Cargo should be separate classes
        private string model = string.Empty;
        private Engine engine = new Engine();
        private Cargo cargo = new Cargo();
        private List<Car> cars = new List<Car>();
        public void Add(string model, Engine engine, Cargo cargo)
        {
            Car car = new Car();
            car.model = model;
            car.engine = engine;
            car.cargo = cargo;

            cars.Add(car);
        }

        public void DisplayCarType(string type)
        {
            var temp = new List<string>();
            switch (type)
            {
                case "fragile":
                    temp = cars.Where(x => x.cargo.Type == type).Where(x => x.cargo.Weight < 1000).Select(car => car.model).ToList();
                    break;
                case "flamable":
                    temp = cars.Where(x => x.cargo.Type == type).Where(x => x.engine.Power > 250).Select(car => car.model).ToList();
                    break;
            }

            Console.WriteLine(string.Join("\n", temp));
        }
    }
}
