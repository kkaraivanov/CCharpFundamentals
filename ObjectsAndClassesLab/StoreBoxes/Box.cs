using System.Collections.Generic;
using System.Text;

namespace StoreBoxes
{
    class Box
    {
        private long SerialNumber { get; set; }
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
        public string DisplayOrderedBoxes()
        {
            Boxes = Boxes.OrderByDescending(boxPrice => boxPrice.PriceTheBox).ToList();
            var sb = new StringBuilder();

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
                sb.AppendLine($"{box.SerialNumber}");
                sb.AppendLine($"-- {name} - ${price:f2}: {box.ItemQuantity}");
                sb.AppendLine($"-- ${box.PriceTheBox:f2}");
            }
            return sb.ToString();
        }
    }
}
