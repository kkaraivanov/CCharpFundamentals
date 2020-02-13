using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int factoriel = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int n = int.Parse(number[i].ToString());
                int f = 1;
                do
                {
                    f *= n;
                    n--;
                } while (n > 1);
                factoriel += f;
            }
            
            if (factoriel == int.Parse(number))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
