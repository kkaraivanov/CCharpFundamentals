namespace SoftUniExamResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            var cource = new Dictionary<string, double>();
            var courceLanguage = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string user = input.Split('-')[0];
                string language = input.Split('-')[1];

                if (language != "banned")
                {
                    double grade = double.Parse(input.Split('-')[2]);
                    if (!cource.ContainsKey(user))
                        cource[user] = 0;

                    if (!courceLanguage.ContainsKey(language))
                        courceLanguage[language] = 0;

                    if (cource[user] < grade)
                        cource[user] = grade;
                    courceLanguage[language]++;
                }
                else
                    cource.Remove(user);
            }

            Console.WriteLine("Results:");
            foreach (var user in cource.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var language in courceLanguage.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
