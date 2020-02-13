using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = ColectPeopel().ToList();
            
            foreach (var people in peoples.OrderBy(people => people.Age))
            {
                Console.WriteLine($"{people.Nmae} with ID: {people.ID} is {people.Age} years old.");
            }
        }

        private static List<People> ColectPeopel()
        {
            List<People> peoples = new List<People>();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                People people = new People();
                people.ID = long.Parse(line.Split()[1]);
                people.Nmae = line.Split()[0];
                people.Age = int.Parse(line.Split()[2]);
                peoples.Add(people);
            }
            
            return peoples;
        }
    }

    class People
    {
        public long ID { get; set; }
        public string Nmae { get; set; }
        public int Age { get; set; }
    }
}
