namespace _9.Enroll_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string FacultyNumber { get; set; }
        public List<int> Marks { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            var student = Console.ReadLine().Split().ToList();
            var studentList = new List<Student>();
            while (student[0] != "END")
            {
                var currentStudentMarks = new List<int>();
                for (int i = 1; i < student.Count; i++)
                {
                    currentStudentMarks.Add(int.Parse(student[i]));
                }
                var currentStuden = new Student()
                {
                    FacultyNumber = student[0],
                    Marks = currentStudentMarks
                };
                studentList.Add(currentStuden);
                student = Console.ReadLine().Split().ToList();
            }
            foreach (var studen in studentList.Where(f => f.FacultyNumber.EndsWith("14") || f.FacultyNumber.EndsWith("15")))
            {
                Console.WriteLine(string.Join(" ", studen.Marks));
            }
        }
    }
}