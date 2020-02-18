using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                var line = Console.ReadLine().Split();
                Person person = new Person();

                person.Name = line[0];
                person.Age = int.Parse(line[1]);
                Family.AddMember(person);
            }

            var olderPerson = Family.GetOldestMember();
            Console.WriteLine($"{olderPerson.Name} {olderPerson.Age}");
        }
    }
}
