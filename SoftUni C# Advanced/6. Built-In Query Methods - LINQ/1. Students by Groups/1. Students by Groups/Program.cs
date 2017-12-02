namespace _1.Students_by_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Group { get; set; }
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
                    Group = int.Parse(student[2])
                };
                studentList.Add(currentStuden);
                student = Console.ReadLine().Split().ToList();
            }
            foreach (var studen in studentList.Where(x => x.Group == 2).OrderBy(x => x.Name).ThenBy(x => x.Surname))
            {
                Console.WriteLine($"{studen.Name} {studen.Surname}");
            }
        }
    }
}


