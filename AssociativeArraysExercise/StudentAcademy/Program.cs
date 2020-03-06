namespace StudentAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < line; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(student))
                    students[student] = new List<double>();

                students[student].Add(grade);
            }

            Console.WriteLine(string.Join($"{Environment.NewLine}",students
                .Where(x => (x.Value.Sum() / x.Value.Count) >= 4.50)
                .OrderByDescending(x => x.Value.Sum() / x.Value.Count)
                .Select(x => $"{x.Key} -> {x.Value.Sum() / x.Value.Count():f2}")));
        }
    }
}
