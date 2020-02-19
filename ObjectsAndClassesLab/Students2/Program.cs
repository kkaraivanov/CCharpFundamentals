using System;
using System.Collections.Generic;
using System.Linq;

namespace Students2
{
    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.NewStudents();

            string city = Console.ReadLine();
            foreach (var student in students.GetStudentFromCity(city))
                Console.WriteLine(student);
        }
    }
}
