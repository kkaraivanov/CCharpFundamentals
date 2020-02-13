using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine()); //цена на мечовете
            double robesPrice = double.Parse(Console.ReadLine()); //цена на дрехите
            double beltsPrice = double.Parse(Console.ReadLine()); //цена на колани

            double allbeltsPrice = 0;
            int counter = 0;
            for (int i = 0; i < students; i++)
            {
                counter++;
                if (counter == 6)
                {
                    counter = 0;
                    continue;
                }
                else
                    allbeltsPrice += beltsPrice;
            }
            
            double totalPrice = (sabrePrice * (students + (Math.Ceiling(students * 0.10)))) + (robesPrice * students) + allbeltsPrice;
            if (totalPrice <= amountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else if (totalPrice > amountMoney)
            {
                totalPrice -= amountMoney;
                Console.WriteLine($"Ivan Cho will need {totalPrice:f2}lv more.");
            }
        }
    }
}
