namespace Santa_sSecretHelper
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            int.TryParse(Console.ReadLine(), out int key);
            string commands = null;

            while ((commands = Console.ReadLine()) != "end")
            {
                var sb = new StringBuilder();

                for (int i = 0; i < commands.Length; i++)
                {
                    int temp = commands[i] - key;
                    sb.Append(Convert.ToString((char)temp));
                }
                
                var match = Regex.Match(sb.ToString(), @"[\@]([A-Za-z]+)[^@\-\!\:\>]*\!([GN])\!");
                string name = match.Groups[1].ToString();
                string behaviour = match.Groups[2].ToString();

                if(behaviour == "G")
                    Console.WriteLine(name);
            }
        }
    }
}
