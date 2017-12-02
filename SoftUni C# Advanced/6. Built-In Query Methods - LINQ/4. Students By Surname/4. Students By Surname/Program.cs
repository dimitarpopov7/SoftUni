namespace _4.Students_By_Surname
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
    class Program
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
            foreach (var studen in studentList.OrderBy(x=>x.Surname))
            {
                Console.WriteLine($"{studen.Name} {studen.Surname}");
            }
        }
    }
}
