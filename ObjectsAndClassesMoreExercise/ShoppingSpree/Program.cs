using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            var products = new List<Product>();

            var line = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            AddPerson(persons, line);

            line = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            AddProducts(products, line);

            var commands = string.Empty;
            while ((commands = Console.ReadLine()) != "END")
            {
                PurchuaseProduct(persons, products, commands);
            }

            DisplayPersonPurchase(persons);
        }

        private static void AddPerson(List<Person> persons, string[] line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                var person = new Person();
                person.Name = line[i].Split('=')[0];
                person.Money = decimal.Parse(line[i].Split('=')[1]);
                persons.Add(person);
            }
        }

        private static void AddProducts(List<Product> products, string[] line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                var product = new Product();
                product.Name = line[i].Split('=')[0];
                product.Cost = decimal.Parse(line[i].Split('=')[1]);
                products.Add(product);
            }
        }

        private static void PurchuaseProduct(List<Person> persons, List<Product> products, string commands)
        {
            var command = commands.Split();
            Person person = new Person();
            Product product = new Product();
            var personName = command[0];
            var purchase = command[1];
            var purchaseMoney = products.Where(x => x.Name == purchase).Select(x => x.Cost).ToList()[0];
            var personMoney = persons.Where(x => x.Name == personName).Select(x => x.Money).ToList()[0];
            var personBag = persons.Where(x => x.Name == personName).Select(x => x.Bag.ToList()).ToList()[0];
            var personIndex = persons.FindIndex(x => x.Name == personName);
            if (personMoney >= purchaseMoney)
            {
                person.Name = personName;
                person.Money = personMoney - purchaseMoney;
                product.Name = purchase;
                product.Cost = purchaseMoney;
                personBag.Add(product);
                person.Bag = personBag.ToList();

                persons.RemoveAt(personIndex);
                persons.Insert(personIndex, person);
                Console.WriteLine($"{personName} bought {purchase}");
            }
            else
                Console.WriteLine($"{personName} can't afford {purchase}");
        }

        private static void DisplayPersonPurchase(List<Person> persons)
        {
            foreach (var person in persons)
            {
                if (person.Bag.Count == 0)
                    Console.WriteLine($"{person.Name} - Nothing bought");
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag.Select(x => x.Name).ToList())}");
                }
            }
        }
    }
}
