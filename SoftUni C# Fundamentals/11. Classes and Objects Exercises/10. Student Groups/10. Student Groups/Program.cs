namespace _10.Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;    
    public class Program
    {
        public static void Main()
        {
            var townList = new List<Town>();
            var studentList = new List<Student>();
            var groupList = new List<Group>();
            string entry = Console.ReadLine();
            while (true)
            {
                Start:
                if (entry != "End")
                {
                    var currentTown = new Town();
                    if (entry.Contains("=>"))
                    {
                        //Records town data
                        var townData = entry.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                        var townDataSeats = townData[1].Split(' ');
                        currentTown.TownName = townData[0];
                        currentTown.SeatsAvailable = int.Parse(townDataSeats[0]);
                        //Keeps record of towns
                        townList.Add(currentTown);
                        entry = Console.ReadLine();
                        var currentStudentList = new List<Student>();
                        var currentGroupsList = new List<Group>();
                        while (entry.Contains(" | "))
                        {
                            var currentStudent = new Student();
                            var studentInfo = entry.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                            //Records Student
                            currentStudent.Name = studentInfo[0];
                            currentStudent.Email = studentInfo[1];
                            currentStudent.Date = DateTime.Parse(studentInfo[2], CultureInfo.InvariantCulture);
                            //Adds a list of students to their town
                            currentStudentList.Add(currentStudent);
                            currentTown.StudentList = currentStudentList;
                            entry = Console.ReadLine();
                        }
                    }
                    goto Start;
                }
                else
                {
                    break;
                }
            }
            //Fill out groups by town            
            Console.WriteLine("test");
            foreach (var town in townList.OrderBy(x=>x.TownName))
            {
                int seatsCount = town.SeatsAvailable;
                //Sort the students by Date,Name,Email
                IEnumerable<Student> students = town.StudentList//FIND OUT WHAT IS THAT?
                    .OrderBy(x => x.Date)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email);
                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town.TownName;
                    group.GroupMembers = students.Take(seatsCount).ToList();
                    students = students.Skip(seatsCount);
                    groupList.Add(group);
                }
            }
            //Print out results
            Console.WriteLine($"Created {groupList.Count} groups in {townList.Count} towns:");
            foreach (var group in groupList)
            {
                Console.Write($"{group.Town} => ");
                for (int i = 0; i < group.GroupMembers.Count; i++)
                {
                    if (i != group.GroupMembers.Count - 1)
                    {
                        Console.Write($"{group.GroupMembers[i].Email}, ");
                    }
                    else
                    {
                        Console.Write(group.GroupMembers[i].Email);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
