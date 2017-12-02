namespace _11.Speciality
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }
        public List<string> Speciality { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var studentsList = new Dictionary<string, Student>();
            while (input[0] != "Students:")
            {
                var speciality = new List<string> { $"{input[0]} {input[1]}" };
                var facultyNum = input[2];
                var currentStudent = new Student() { Speciality = speciality };
                if (!studentsList.ContainsKey(facultyNum))
                {
                    studentsList[facultyNum] = currentStudent;
                }
                else
                {
                    studentsList[facultyNum].Speciality.Add($"{input[0]} {input[1]}");
                }
                input = Console.ReadLine().Split().ToList();
            }
            input = Console.ReadLine().Split().ToList();
            while (input[0] != "END")
            {
                var facultyNum = input[0];
                var studentName = $"{input[1]} {input[2]}";
                if (studentsList.ContainsKey(facultyNum))
                {
                    studentsList[facultyNum].Name = studentName;
                }
                input = Console.ReadLine().Split().ToList();
            }
            foreach (var student in studentsList.OrderBy(x => x.Value.Name))
            {
                foreach (var special in student.Value.Speciality)
                {
                    Console.WriteLine($"{student.Value.Name} {student.Key} {special}");
                }
            }
        }
    }
}

