namespace _04.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> listOfStudents = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split(' ').ToList();
                var justGrades = new List<double>();
                for (int k = 1; k < entry.Count; k++)
                {
                    justGrades.Add(double.Parse(entry[k]));
                }
                listOfStudents.Add(new Student
                {
                    Name = entry[0],
                    Grades = justGrades                    
                });
            }
            foreach (var excellentStudent in listOfStudents.OrderBy(x=>x.Name).ThenByDescending(x=>x.AvrgGrade))
            {
                if (excellentStudent.AvrgGrade >= 5.00)
                {
                    Console.WriteLine($"{excellentStudent.Name} -> {excellentStudent.AvrgGrade:f2}");
                }                
            }            
        }
    }
}
