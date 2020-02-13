using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(ReturnGredeWord(grade));
        }
        static string ReturnGredeWord(double grade)
        {
            string result = string.Empty;
            if (grade >= 2.00 && grade <= 6.00)
            {
                result = grade < 3.00 ? "Fail" :
                         grade < 3.50 ? "Poor" :
                         grade < 4.50 ? "Good" :
                         grade < 5.50 ? "Very good" :
                         "Excellent";
            }
            return result;
        }
    }
}
