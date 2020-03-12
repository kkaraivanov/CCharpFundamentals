namespace NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var demonsHealth = new SortedDictionary<string,int>();
            var demonsDamage = new SortedDictionary<string, double>();

            foreach (var demonName in demons)
            {
                string patternHealth = @"[^0-9+\-\*\/.]";
                string patternDamage = @"-?\d+\.?\d*";
                var matchHealth = Regex.Matches(demonName, patternHealth);
                var matchDamage = Regex.Matches(demonName, patternDamage);
                int health = GetHealth(matchHealth);
                double damage = GetDamage(demonName, matchDamage);

                demonsHealth[demonName] = health;
                demonsDamage[demonName] = damage;
            }

            foreach (var demon in demonsDamage)
            {
                Console.WriteLine($"{demon.Key} - {demonsHealth[demon.Key]} health, {demon.Value:f2} damage ");
            }
        }
        private static int GetHealth(MatchCollection matchName)
        {
            int health = 0;
            foreach (Match item in matchName)
            {
                string str = item.ToString();
                int x = str[0];
                health += x;
            }

            return health;
        }
        private static double GetDamage(string demon, MatchCollection matchDamage)
        {
            double damage = 0;
            foreach (Match item in matchDamage)
            {
                damage += double.Parse(item.ToString());
            }

            damage = CalculateDamage(demon, damage);
            return damage;
        }
        private static double CalculateDamage(string arr, double d)
        {
            foreach (var item in arr)
            {
                if (item == '*')
                    d *= 2;
                else if (item == '/')
                    d /= 2;
            }

            return d;
        }
    }
}
