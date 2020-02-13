using System;

namespace DataTypes
{
    class Program
    {
        delegate void GetLine(string line);
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string line = Console.ReadLine();

            GetLine getLine = type == "int" ? new GetLine(GetInteger) :
                              type == "real" ? new GetLine(GetDouble) :
                              type == "string" ? new GetLine(GetString) : null;
            getLine(line);
        }

        static void GetInteger(string line)
        {
            Console.WriteLine(int.Parse(line) * 2);
        }
        static void GetDouble(string line)
        {
            Console.WriteLine($"{double.Parse(line) * 1.5:f2}");
        }
        static void GetString(string line)
        {
            Console.WriteLine($"${line}$");
        }
    }
}
