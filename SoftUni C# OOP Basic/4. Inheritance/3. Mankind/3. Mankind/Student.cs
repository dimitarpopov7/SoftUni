namespace _3.Mankind
{
    using System;
    using System.Text;

    public class Student : Human
    {
        private string facultyNum;
        public string FacultyNum
        {
            get { return this.facultyNum; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNum = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("First Name: ").AppendLine(this.FirstName);
            sb.Append("Last Name: ").AppendLine(this.LastName);            
            sb.Append("Faculty number: ").AppendLine(this.facultyNum);
            return sb.ToString();
        }
        public Student(string firstName, string LastName, string facultyNum)
        : base(firstName, LastName)
        {
            this.FacultyNum = facultyNum;
        }
    }
} 