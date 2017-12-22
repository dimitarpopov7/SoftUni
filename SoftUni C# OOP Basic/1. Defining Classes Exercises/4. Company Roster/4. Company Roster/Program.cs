namespace _4.Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var employeeList = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split().ToList();
                int age = 0;
                string email = string.Empty;
                if (entry.Count > 4)
                {

                    var ageOrEmail = entry[4];
                    if (ageOrEmail.IndexOf("@") > 0)
                    {
                        email = ageOrEmail;
                    }
                    else
                    {
                        age = int.Parse(entry[4]);
                    }
                }
                if (entry.Count > 5)
                {
                    age = int.Parse(entry[5]);
                }
                if (age == 0)
                {
                    age = -1;
                }
                if (email == string.Empty)
                {
                    email = "n/a";
                }
                var currentEmployee = new Employee(entry[0], double.Parse(entry[1]), entry[2], entry[3], email, age);

                employeeList.Add(currentEmployee);
            }

            var result = employeeList.GroupBy(x => x.Department)
                            .OrderByDescending(x => x.Select(e => e.Salary).Average())
                            .FirstOrDefault();
            if (employeeList.Count == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine($"Highest Average Salary: {result.Key}");
                foreach (var employee in result.OrderByDescending(x => x.Salary))
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
                }
            }            
        }
    }
}
