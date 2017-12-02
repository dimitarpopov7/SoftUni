namespace _5.Students_Filter_by_Email
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
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
                    Surname = student[1],
                    Email=student[2]
                };
                studentList.Add(currentStuden);
                student = Console.ReadLine().Split().ToList();
            }
            foreach (var studen in studentList.Where(x => x.Email.Contains("@gmail.com")))
            {
                Console.WriteLine($"{studen.Name} {studen.Surname}");
            }
        }
    }
}
