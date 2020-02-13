using System;

namespace Calculations
{
    class Program
    {
        // add, multiply, subtract, divide
        delegate void GetResult(int a, int b);
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            GetResult getResult = command == "add" ? new GetResult(Add) :
                                  command == "multiply" ? new GetResult(Multiply) :
                                  command == "subtract" ? new GetResult(Subtract) :
                                  command == "divide" ? new GetResult(Divide) : null;
            getResult(a, b);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(Math.Abs(a - b));
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine(b != 0 ? a / b : b / a);
        }
    }
}
