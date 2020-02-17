using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string queryItem = string.Empty;
            Box box = new Box();

            while ((queryItem = Console.ReadLine()) != "end")
            {
                box.AddNewItem(queryItem);
            }
            box.DisplayOrderedBoxes();
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        private long SerialNumber {get; set;}
        private List<Item> Items { get; set; } = new List<Item>();
        private int ItemQuantity { get; set; }
        private decimal PriceTheBox { get; set; }

        // {Serial Number} {Item Name} {Item Quantity} {itemPrice}
        private List<Box> Boxes { get; set; } = new List<Box>();
        public void AddNewItem(string query)
        {
            Item item = new Item();
            Box box = new Box();
            box.SerialNumber = long.Parse(query.Split()[0]);
            item.Name = query.Split()[1];
            box.ItemQuantity = int.Parse(query.Split()[2]);
            item.Price = decimal.Parse(query.Split()[3]);
            box.PriceTheBox = int.Parse(query.Split()[2]) * decimal.Parse(query.Split()[3]);

            box.Items.Add(item);
            Boxes.Add(box);
        }
        public void DisplayOrderedBoxes()
        {
            Boxes = Boxes.OrderByDescending(boxPrice => boxPrice.PriceTheBox).ToList();

            foreach (var box in Boxes)
            {
                //{ boxSerialNumber}
                //-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
                //-- ${ boxPrice}
                string name = "";
                decimal price = 0;
                foreach (var item in box.Items)
                {
                    name = item.Name;
                    price = item.Price;
                }
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {name} - ${price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceTheBox:f2}");
            }
        }
    }
}
