namespace _10.Group_by_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string FullName { get; set; }
        public int Group { get; set; }
    }    
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var Groups = new Dictionary<int, List<string>>();
            while (input[0] != "END")
            {
                var currentStudent = new Student() { FullName = $"{input[0]} {input[1]}", Group=int.Parse(input[2]) };
                if (!Groups.ContainsKey(currentStudent.Group))
                {
                    var list = new List<string>() { currentStudent.FullName };
                    Groups[currentStudent.Group]=list;
                }
                else
                {
                    Groups[currentStudent.Group].Add(currentStudent.FullName);
                }
                input = Console.ReadLine().Split().ToList();
            }
            foreach (var group in Groups.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{group.Key} - {(string.Join(", ",group.Value))}");
            }
        }
    }
}
