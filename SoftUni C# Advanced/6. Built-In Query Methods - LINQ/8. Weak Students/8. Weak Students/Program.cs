namespace _8.Weak_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
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
                for (int i = 2; i < student.Count; i++)
                {
                    currentStudentMarks.Add(int.Parse(student[i]));
                }
                var currentStuden = new Student()
                {
                    Name = student[0],
                    Surname = student[1],
                    Marks = currentStudentMarks
                };
                studentList.Add(currentStuden);
                student = Console.ReadLine().Split().ToList();
            }
            foreach (var studen in studentList.Where(s => s.Marks.Where(n => n <= 3).Count() >= 2))
            {
                Console.WriteLine($"{studen.Name} {studen.Surname}");
            }
        }
    }
}