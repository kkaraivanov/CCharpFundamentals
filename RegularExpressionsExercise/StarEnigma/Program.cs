namespace StarEnigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var attacedPlanets = new Dictionary<string,List<int>>();
            var destroyedPlanet = new Dictionary<string,List<int>>();

            for (int i = 0; i < num; i++)
            {
                string rgx = $"[STARstar]";
                string input = Console.ReadLine();
                var match = Regex.Matches(input, rgx);

                int key = match.Count;
                string message = null;
                for (int j = 0; j < input.Length; j++)
                {
                    int currentLetter = input[j] - key;
                    message += Convert.ToString((char)currentLetter);
                }

                rgx = @"@([A-Z][a-z]+)[^@\-!.]*\:(\d+)!([A|D])![^@\-!.]*\->(\d+)";
                var decripted = Regex.Match(message, rgx);

                if (decripted.Success)
                {
                    if(decripted.Groups[3].Value == "A")
                    {
                        if (!attacedPlanets.ContainsKey(decripted.Groups[1].Value))
                            attacedPlanets[decripted.Groups[1].Value] = new List<int>();

                        attacedPlanets[decripted.Groups[1].Value].Insert(0, int.Parse(decripted.Groups[2].Value));
                        attacedPlanets[decripted.Groups[1].Value].Insert(1, int.Parse(decripted.Groups[4].Value));
                    }
                    else if (decripted.Groups[3].Value == "D")
                    {
                        if (!destroyedPlanet.ContainsKey(decripted.Groups[1].Value))
                            destroyedPlanet[decripted.Groups[1].Value] = new List<int>();

                        destroyedPlanet[decripted.Groups[1].Value].Insert(0, int.Parse(decripted.Groups[2].Value));
                        destroyedPlanet[decripted.Groups[1].Value].Insert(1, int.Parse(decripted.Groups[4].Value));
                    }
                }
            }
            
            if(attacedPlanets.Keys.Count > 0)
                Console.WriteLine($"Attacked planets: {attacedPlanets.Count}{Environment.NewLine}" +
                    $"{string.Join(Environment.NewLine,attacedPlanets.OrderBy(x => x.Value[0]).ThenBy(x => x.Value[1]).Select(x => $"-> {x.Key}"))}");
            else
                Console.WriteLine("Attacked planets: 0");
            
            if(destroyedPlanet.Keys.Count > 0)
                Console.WriteLine($"Destroyed planets: {destroyedPlanet.Count}{Environment.NewLine}" +
                    $"{string.Join(Environment.NewLine, destroyedPlanet.OrderBy(x => x.Value[0]).ThenBy(x => x.Value[1]).Select(x => $"-> {x.Key}"))}");
            else
                Console.WriteLine("Destroyed planets: 0");
        }
    }
}
