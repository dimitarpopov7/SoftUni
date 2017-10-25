namespace _08.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    public class Program
    {
        public static void Main()
        {
            string input = "./TextFile1.txt";
            string output = "./Output.txt";
            var lines = File.ReadAllLines(input).ToList();
            var studentRegister = new Dictionary<int,List<Student>>();
            
            int k = 1;
            for (int i = 0; i < lines.Count; i=i+k)
            {
                var currentLine = lines[i].Split(' ').ToList();
                if (currentLine.Count == 1)
                {
                    var individualStudent = new List<Student>();
                    for (int j = 1; j <= Convert.ToInt32(currentLine[0]); j++)
                    {
                        var studentInfo = lines[i + j].Split(' ').ToList();
                        var studentGrades = studentInfo.Skip(1).Take(studentInfo.Count - 1).Select(x=> double.Parse(x)).ToList();
                        var currentStudent = new Student() { Name = studentInfo[0] };
                        currentStudent.Grades = studentGrades;                        
                        individualStudent.Add(currentStudent);
                    }
                    int schoolEntries = Convert.ToInt32(currentLine[0]);
                    studentRegister[schoolEntries] = individualStudent;
                }
                int num = Convert.ToInt32(currentLine[0]);
                k = num+1;
            }
            foreach (var school in studentRegister.Select(x=>x.Value))
            {                
                foreach (var student in school)
                {
                    File.AppendAllText(output, ($"{student.Name} -> Overall grade: {student.AverageGrades:f2}"));
                    File.AppendAllText(output, Environment.NewLine);
                }
                File.AppendAllText(output, new string('-', 30));
                File.AppendAllText(output, Environment.NewLine);
            }
        }
    }
}
