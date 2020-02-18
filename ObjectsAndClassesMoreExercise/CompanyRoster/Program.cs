using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());
            Employee emp = new Employee();
            for (int i = 0; i < numLines; i++)
            {
                emp.AddAmpoyee(Console.ReadLine());
            }
            emp.GetBigSalaryDepartment();
        }
    }
}
