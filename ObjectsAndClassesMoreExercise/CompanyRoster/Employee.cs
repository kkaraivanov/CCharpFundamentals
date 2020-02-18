using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyRoster
{
    class Employee
    {
        // name, salary, department
        private List<Employee> listWithEmployees = new List<Employee>();
        private string Name { get; set; }
        private decimal Salary { get; set; }
        private string Department { get; set; }

        public void AddAmpoyee(string lineOfData)
        {
            Employee newEmployee = new Employee();
            newEmployee.Name = lineOfData.Split()[0];
            newEmployee.Salary = decimal.Parse(lineOfData.Split()[1]);
            newEmployee.Department = lineOfData.Split()[2];
            listWithEmployees.Add(newEmployee);
        }
        public void GetBigSalaryDepartment()
        {
            decimal bigSalary = 0;
            string department = string.Empty;

            foreach (var employee in listWithEmployees)
            {
                var temp = listWithEmployees.Where(x => x.Department.Contains(employee.Department)).ToList();
                var sum = temp.Sum(x => x.Salary) / temp.Count;

                if (sum > bigSalary)
                {
                    bigSalary = sum;
                    department = employee.Department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {department}");
            foreach (var item in listWithEmployees.OrderByDescending(x => x.Salary).Where(x => x.Department == department))
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2}");
            }

        }
    }
}
