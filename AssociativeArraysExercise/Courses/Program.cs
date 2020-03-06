namespace Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string commands = null;
            var cources = new Dictionary<string, List<string>>();

            while ((commands = Console.ReadLine()) != "end")
            {
                string coursName = commands.Split(" : ", 2)[0];
                string student = commands.Split(" : ", 2)[1];

                if (!cources.ContainsKey(coursName))
                    cources[coursName] = new List<string>();
                cources[coursName].Add(student);
            }
            cources = cources
                .OrderByDescending(x => x.Value.Count())
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine(string.Join($"{Environment.NewLine}",
                cources.Select(x => $"{x.Key}: {x.Value.Count()}\n" +
                $"{string.Join($"{Environment.NewLine}", x.Value.OrderBy(x => x).Select(v => "-- " + v))}")));
        }
    }
}
