namespace CompanyUsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string command = null;
            var companyes = new Dictionary<string, List<string>>();

            while ((command = Console.ReadLine()) != "End")
            {
                string company = command.Split(" -> ")[0];
                string number = command.Split(" -> ")[1];

                if (!companyes.ContainsKey(company))
                    companyes[company] = new List<string>();

                if (companyes[company].Contains(number))
                    continue;

                companyes[company].Add(number);
            }

            companyes = companyes
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine(string.Join($"{Environment.NewLine}", companyes
                .Select(x => $"{x.Key}{ Environment.NewLine}" +
                $"{string.Join($"{Environment.NewLine}", x.Value.Select(t => "-- " + t))}")));
        }
    }
}
