using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupPeople = int.Parse(Console.ReadLine());
            string groupPeopleType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            string[,] table = { { "", "Friday", "Saturday", "Sunday" },
                                { "Students", "8.45", "9.80", "10.46"},
                                { "Business", "10.90", "15.60", "16"},
                                { "Regular", "15", "20", "22.50"} };

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[0, j].Equals(dayOfWeek) && table[i, 0].Equals(groupPeopleType))
                    {
                        decimal price = decimal.Parse(table[i, j]) * groupPeople;
                        if (table[i, 0] == table[1, 0] && groupPeople >= 30)
                        {
                            Console.WriteLine($"Total price: {(price * (decimal)0.85):f2}");
                        }
                        else if (table[i, 0] == table[2, 0] && groupPeople >= 100)
                        {
                            decimal discount = decimal.Parse(table[i, j]) * (groupPeople - 10);
                            Console.WriteLine($"Total price: {discount:f2}");
                        }
                        else if (table[i, 0] == table[3, 0] && (groupPeople >= 10 && groupPeople <= 20))
                        {
                            Console.WriteLine($"Total price: {(price * (decimal)0.95):f2}");
                        }
                        else
                            Console.WriteLine($"Total price: {price:f2}");
                    }
                }
            }
        }
    }
}
