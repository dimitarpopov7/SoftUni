namespace _07.Student_Groups
{
    using _10.Studen_Groups_2;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            List<Town> towns = new List<Town>();
            string entry = Console.ReadLine();            
            while (entry != "End")
            {
                if (entry.IndexOf("=>") != -1)
                {
                    towns.Add(ReadTown(entry));
                }
                else
                {
                    towns[towns.Count - 1].Students.Add(ReadStudent(entry));
                }
                entry = Console.ReadLine();
            }
            List<Group> groups = DistributeStudentsIntoGroups(towns);
            Console.WriteLine("Created {0} groups in {1} towns:", groups.Count, towns.Count);
            foreach (Group group in groups.OrderBy(g => g.Town.Name))
            {
                Console.WriteLine("{0} => {1}", group.Town.Name, string.Join(", ", group.Students.Select(s => s.Email).ToList()));
            }
        }
        static Town ReadTown(string input)
        {
            string[] townInfo = input.Split(new[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);
            string name = townInfo[0].Trim();
            int seatsCount = int.Parse(townInfo[1].Trim().Split(' ')[0]);
            List<Student> students = new List<Student>();
            return new Town { Name = name, SeatsCount = seatsCount, Students = students };
        }
        static Student ReadStudent(string input)
        {
            string[] studentInfo = input.Split('|');
            string name = studentInfo[0].Trim();
            string email = studentInfo[1].Trim();
            DateTime registrationDate = DateTime.ParseExact(studentInfo[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

            return new Student { Name = name, Email = email, RegistrationDate = registrationDate };
        }

        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();
            foreach (Town town in towns)
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email);
                while (students.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }
            return groups;
        }
    }
}