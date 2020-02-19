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
                var id = long.Parse(line.Split()[1]);
                var name = line.Split()[0];
                var age = int.Parse(line.Split()[2]);
                var people = new People(id, name, age);
                peoples.Add(people);
            }
            
            return peoples;
        }
    }

    class People
    {
        public People(long id, string name, int age)
        {
            this.ID = id;
            this.Nmae = name;
            this.Age = age;
        }
        public long ID { get; set; }
        public string Nmae { get; set; }
        public int Age { get; set; }
    }
}
