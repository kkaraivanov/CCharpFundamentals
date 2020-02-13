using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int vagons = int.Parse(Console.ReadLine());
            int[] people = new int[vagons];

            for (int i = 0; i < vagons; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", people));
            Console.WriteLine(people.Sum());
        }
    }
}
