using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countStudents; i++)
            {
                string[] student = Console.ReadLine().Split().ToArray();
                var newStudent = new Student(student[0], student[1], double.Parse(student[2]));
                students.Add(newStudent);
            }
            students = students.OrderByDescending(student => student.Grade).ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
    class Student
    {
        public Student(string name, string lastName, double grade)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public double Grade { get; private set; }

        public override string ToString()
        {
            return $"{Name} {LastName}: {Grade:f2}";
        }
    }
}
