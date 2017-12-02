namespace _2.Student_By_F_and_L_name
{    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            var student = Console.ReadLine().Split().ToList();
            var studentList = new List<Student>();
            while (student[0] != "END")
            {
                var currentStuden = new Student()
                {
                    Name = student[0],
                    Surname = student[1]
                };
                studentList.Add(currentStuden);
                student = Console.ReadLine().Split().ToList();
            }
            foreach (var studen in studentList.Where(x => x.Name.CompareTo(x.Surname) < 0))
            {
                Console.WriteLine($"{studen.Name} {studen.Surname}");
            }
        }
    }

}
