using System;
using System.Linq;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double input1 = double.Parse(Console.ReadLine());
            double input2 = double.Parse(Console.ReadLine());
            Console.WriteLine(MyEqual(input1, input2, 0.000001));
        }
        static bool MyEqual(double ferstNum, double secondNum, double eps)
        {
            double ferstNumber = Math.Abs(ferstNum);
            double secondNumber = Math.Abs(secondNum);
            double diff = Math.Abs(ferstNum - secondNum);

            if (ferstNum == 0 || secondNum == 0 || diff < eps)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
