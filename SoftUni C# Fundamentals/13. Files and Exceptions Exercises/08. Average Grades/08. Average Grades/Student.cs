﻿namespace _08.Average_Grades
{    
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrades => Grades.Average();
    }
}
