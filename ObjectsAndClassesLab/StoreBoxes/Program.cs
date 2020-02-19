using System;

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

            Console.Write(box.DisplayOrderedBoxes());
        }
    }
}
