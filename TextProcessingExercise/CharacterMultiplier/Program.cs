namespace CharacterMultiplier
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var stringOne = line.Split()[0];
            var stringTwo = line.Split()[1];
            var minLength = Math.Min(stringOne.Length, stringTwo.Length);
            string stringTemp = null;

            if (minLength == stringOne.Length)
            {
                stringTemp = stringTwo.Substring(minLength, stringTwo.Length - minLength);
                stringTwo = stringTwo.Substring(0, stringTwo.Length - stringTemp.Length);
            }
            else
            {
                stringTemp = stringOne.Substring(minLength, stringOne.Length - minLength);
                stringOne = stringOne.Substring(0, stringOne.Length - stringTemp.Length);
            }

            Console.WriteLine(GetCharactersSum(stringOne, stringTwo, stringTemp));
        }

        private static int GetCharactersSum(string stringOne, string stringTwo, string stringTemp)
        {
            int counter = 0;
            int result = 0;
            foreach (var ferst in stringOne)
            {
                result += stringOne[counter] * stringTwo[counter];
                counter++;
            }

            if (stringTemp != null)
                foreach (var item in stringTemp)
                    result += item;

            return result;
        }
    }
}
