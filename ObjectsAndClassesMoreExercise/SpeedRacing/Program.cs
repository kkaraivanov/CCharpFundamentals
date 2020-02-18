using System;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            var car = new Car();

            for (int i = 0; i < carsCount; i++)
                car.AddNewCar(Console.ReadLine());

            string commandLine = string.Empty;
            while ((commandLine = Console.ReadLine()) != "End")
                car.Drive(commandLine.Split()[1], long.Parse(commandLine.Split()[2]));

            car.DisplayCarInformation();
        }
    }
}
