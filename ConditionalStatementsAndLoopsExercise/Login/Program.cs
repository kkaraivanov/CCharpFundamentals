using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string password = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                password += input[i];
            }

            string login = Console.ReadLine();
            int loginCounter = 1;
            bool chekBlockedUser = false;
            while (login != password)
            {
                Console.WriteLine("Incorrect password. Try again.");
                loginCounter++;
                if (loginCounter >= 4)
                {
                    Console.WriteLine($"User {input} blocked!");
                    chekBlockedUser = true;
                    break;
                }
                
                login = Console.ReadLine();
            }

            if(!chekBlockedUser)
                Console.WriteLine($"User {input} logged in.");
        }
    }
}
