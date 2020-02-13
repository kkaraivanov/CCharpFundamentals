using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPasslord = Console.ReadLine();
            if(PasswordCharValidation(inputPasslord))
                Console.WriteLine("Password is valid");
            
        }
        static bool PasswordCharValidation(char pass)
        {
            bool result = pass >= 65 && pass <= 90 || pass >= 97 && pass <= 122;
            if (!PasswordCharValidation((long)pass) && !result)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                result = false;
            }
            else
                result = true;

            return result;
        }
        static bool PasswordCharValidation(string pass)
        {
            bool result = pass.Length >= 6 && pass.Length <= 10;

            if (!result)
                Console.WriteLine("Password must be between 6 and 10 characters");

            long sum = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (PasswordCharValidation((int)pass[i]))
                    sum++;
                else if (!PasswordCharValidation(pass[i]))
                {
                    if (sum < 2)
                        Console.WriteLine("Password must have at least 2 digits");
                    return false;
                }
            }
            if (sum < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                result = false;
            }
            else
                result = true;

            return result;
        }
        static bool PasswordCharValidation(long pass)
        {
            return pass >= 48 && pass <= 57 ? true : false;
        }
    }
}
