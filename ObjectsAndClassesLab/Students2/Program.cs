using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
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
    class Students
    {
        private List<Student> StudentsList { get; set; }
        public void NewStudents()
        {
            StudentsList = new List<Student>();
            string inputStudent = string.Empty;

            while ((inputStudent = Console.ReadLine()) != "end")
            {
                Student student = new Student();
                student.FerstName = inputStudent.Split()[0];
                student.LastName = inputStudent.Split()[1];
                student.Age = int.Parse(inputStudent.Split()[2]);
                student.HomeTown = inputStudent.Split()[3];
                
                if(StudentsList.Select(fName => fName.FerstName).Contains(inputStudent.Split()[0]) &&
                   StudentsList.Select(lName => lName.LastName).Contains(inputStudent.Split()[1]))
                {
                    int studentIndex = StudentsList.FindIndex(fName => fName.FerstName == inputStudent.Split()[0]);
                    StudentsList.RemoveAt(studentIndex);
                    StudentsList.Add(student);
                }
                else
                    StudentsList.Add(student);
            }
        }

        public List<string> GetStudentFromCity(string city)
        {
            List<string> result = new List<string>();

            foreach (var studentTown in StudentsList.Where(student => student.HomeTown == city))
                result.Add($"{studentTown.FerstName} {studentTown.LastName} is {studentTown.Age} years old.");

            return result;
        }
    }
    class Student
    {
        //first name, last name, age and hometown.
        public string FerstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
