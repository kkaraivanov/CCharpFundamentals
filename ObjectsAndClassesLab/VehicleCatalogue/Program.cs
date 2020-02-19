using System;

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

            Console.Write(catalog.DisplayVehicleCatalog());
        }
    }
}
