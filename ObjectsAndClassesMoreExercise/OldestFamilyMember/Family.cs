using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldestFamilyMember
{
    class Family
    {
        // Family class should have a list of people,
        // method for adding members
        // and a method, which returns the oldest family member
        private static List<Person> listOfPeople = new List<Person>();

        public static void AddMember(Person member)
        {

            listOfPeople.Add(member);
        }

        public static Person GetOldestMember()
        {
            return listOfPeople.OrderByDescending(x => x.Age).First();
        }
    }
}
